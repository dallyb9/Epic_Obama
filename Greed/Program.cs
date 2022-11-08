using Raylib_cs;
using System.Numerics;

class Program
{
    Gems gems = new Gems();
    Movement movement = new Movement();
    Player player = new Player();
    Position position = new Position();
    Rocks rocks = new Rocks();
    Score score = new Score();
    public static void Main()
    {
        var ScreenHeight = 400;
        var ScreenWidth = 800;
        var BallPosition = new Vector2(ScreenHeight / 2, ScreenWidth / 2);
        var BallMovementSpeed = 10;
        float BallRadius = 50;

        Raylib.InitWindow(ScreenHeight, ScreenWidth, "Ball");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Score.DrawScore();
            
            Movement.playerMovement();

            Raylib.DrawCircleV(BallPosition, BallRadius, Color.MAROON);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
