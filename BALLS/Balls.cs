using Raylib_cs;
using System.Numerics;

class Balls
{
    RandomSelector RandomSelector = new RandomSelector();
    public void Play()
    {
        var ScreenHeight = 720;
        var ScreenWidth = 1280;

        Time time = new Time();
        bool GameOver = false;

        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Shape Land");
        Raylib.SetTargetFPS(60);

        var Player = new Player();
        var Title = new GameText("Link! Please find the area of all the shapes. -Zelda", Color.WHITE);
        // creates new empty list of GameObjects
        var Objects = new List<GameObject>();

        Player.Position = new Vector2(ScreenWidth / 2, ScreenHeight - 100);
        Title.Position = new Vector2(20);


        List<string> colorList = RandomSelector.MakeColorList();
        // loop 4 times
        for (int i = 0; i < 4; i++)
        {
            int xcoordinate = 0;
            int ycoordinate = 0;
            if (i == 0)
            {
                xcoordinate = 0;
                ycoordinate = 0;
            }
            else if (i == 1)
            {
                xcoordinate = 0;
                ycoordinate = ScreenWidth;
            }
            else if (i == 2)
            {
                xcoordinate = ScreenHeight;
                ycoordinate = 0;
            }
            else
            {
                xcoordinate = ScreenHeight;
                ycoordinate = ScreenWidth;
            }
            var circle = new CicleObjective(RandomSelector.RdmNum(), Color.BLUE);
            circle.Position = RandomSelector.RandomPosition(xcoordinate, ycoordinate);
            Objects.Add(circle);
        }

        Objects.Add(Player);
        Objects.Add(Title);
        int score = 0;
        int oldscore = 0;

        while (!Raylib.WindowShouldClose())
        {
            if (oldscore != score)
            {
                // remove all objects from 'Objects' list
                Objects = new List<GameObject>();
                // reset player position
                Player.Position = new Vector2(ScreenWidth / 2, ScreenHeight - 100);
            }
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            Time.Timer();

            // Draw all of the objects in their current location
            foreach (var obj in Objects)
            {
                obj.Draw();
            }

            // Check if link is on any of the shapes
            foreach (var obj in Objects)
            {
                if (obj is Shape)
                {
                    var shape = (Shape)obj;
                    // CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2); 
                    if (Raylib.CheckCollisionRecs(Player.Rect(), shape.CollisionRect()))
                    {
                        var message = $"The area of this {shape.Name()} is {shape.Area()}";
                        Raylib.DrawText(message, 100, 100, 20, Color.WHITE);
                    }

                }
            }

            oldscore = score;

            Raylib.EndDrawing();

            // Move all of the objects to their next location
            foreach (var obj in Objects)
            {
                obj.Move();
            }
        }

        Raylib.CloseWindow();
    }
}