using Raylib_cs;
using System.Numerics;

class Balls
{
    RandomSelector RandomSelector = new RandomSelector();
    public void Play()
    {
        var ScreenHeight = 720;
        var ScreenWidth = 1280;

        //Time time = new Time();
        bool GameOver = false;

        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Shape Land");
        Raylib.SetTargetFPS(60);

        var Player = new Player();

        string winColor = "Unselected color";
        int score = 0;
        int timeRemain = 0;

        
        var scoreText = new GameText($"Score: {score}", Color.WHITE);
        var timerText = new GameText($"Time left: {timeRemain}", Color.WHITE);
        // creates new empty list of GameObjects
        var Objects = new List<GameObject>();

        Player.Position = new Vector2(ScreenWidth / 2, ScreenHeight / 2);
        
        scoreText.Position = new Vector2(20, 20);
        timerText.Position = new Vector2((ScreenWidth / 2) - 60, 50);


        List<string> colorList = RandomSelector.MakeColorList();

        
        // loop 4 times
        for (int i = 0; i < 4; i++)
        {
            var circleColor = Color.WHITE;
            int xcoordinate = 0;
            int ycoordinate = 0;

            switch (colorList[i])
            {
                case "BLUE":
                    circleColor = Color.BLUE;
                    break;
                case "GREEN":
                    circleColor = Color.GREEN;
                    break;
                case "RED":
                    circleColor = Color.RED;
                    break;
                case "YELLOW":
                    circleColor = Color.YELLOW;
                    break;
                default:
                    Console.WriteLine("Color select error");
                    break;
            }
            switch (i)
            {
                case 0:
                    // top left
                    xcoordinate = 0;
                    ycoordinate = 0;
                    break;
                case 1:
                    // top right
                    xcoordinate = ScreenWidth;
                    ycoordinate = 0;
                    break;
                case 2:
                    // bottom left
                    xcoordinate = 0;
                    ycoordinate = ScreenHeight;
                    break;
                case 3:
                    // bottom right
                    xcoordinate = ScreenWidth;
                    ycoordinate = ScreenHeight;
                    break;
                default:
                    Console.WriteLine("i out of range in loop");
                    break;
            }
            // CicleObjective(radius, color);
            var circle = new CicleObjective(200, circleColor);
            circle.Position = new Vector2(xcoordinate, ycoordinate);
            Objects.Add(circle);

            // var circle = new CicleObjective(RandomSelector.RdmNum(), circleColor);
            // circle.Position = RandomSelector.RandomPosition(xcoordinate, ycoordinate);
        }
        
        winColor = colorList[RandomSelector.RdmNum()];
        var winColorText = new GameText($"Find: {winColor}", Color.WHITE);
        winColorText.Position = new Vector2((ScreenWidth / 2) - 60, 100);

        Objects.Add(Player);
        Objects.Add(winColorText);
        Objects.Add(scoreText);
        Objects.Add(timerText);

        
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
            //Time.Timer();

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