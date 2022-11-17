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
        var PlayerPosition = new Vector2(ScreenHeight / 2, ScreenWidth / 2);
        var PlayerMovementSpeed = 10;
        float BallRadius = 50;

        Raylib.InitWindow(ScreenHeight, ScreenWidth, "Ball");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Score.DrawScore();
            
            Movement.playerMovement();
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
        PlayerRectangle.x += MovementSpeed;
        }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
        PlayerRectangle.x -= MovementSpeed;
        }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
        PlayerRectangle.y -= MovementSpeed;
        }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
        PlayerRectangle.y += MovementSpeed;
        }

            Raylib.DrawCircleV(BallPosition, BallRadius, Color.MAROON);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
