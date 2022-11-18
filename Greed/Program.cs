using Raylib_cs;
using System.Numerics;

class Program
{
    

    
    public static void Main()
    {
        Gems gems = new Gems();
    Movement movement = new Movement();
    ObjectColor objectcolor = new ObjectColor();
    Player player = new Player();
    Position position = new Position();
    Rocks rocks = new Rocks();
    Score score = new Score();

        var ScreenHeight = 400;
        var ScreenWidth = 800;
        var PlayerPosition = new Vector2(ScreenHeight / 2, ScreenWidth / 2);
        var Objects = new List<Fallingobject>();
        int framecount = 0;

        Raylib.InitWindow(ScreenHeight, ScreenWidth, "Ball");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            framecount++;
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            score.DrawScore();
            movement.playerMovement();
            string chosencolor = objectcolor.ChooseColor();
            if (framecount == 20){
                rocks.Draw();
                }
            if (framecount == 40){
                gems.Draw();
                framecount = 0;
                }
            }
        Raylib.DrawCircleV(BallPosition, BallRadius, Color.MAROON);

        Raylib.EndDrawing();
        Raylib.CloseWindow();
    }
}
