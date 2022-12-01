using Raylib_cs;
using System.Numerics;



static class Program
    {
        
    public static void Main()
        {
            var ScreenHeight = 480;
            var ScreenWidth = 800;
            int BallPositionX = (ScreenWidth / 2);
            int BallPositionY = (ScreenHeight / 2);
            int BallMovementSpeed = 1;
            float BallRadius = 50;

            GameObjects gameObject1 = new GameObjects();
            GameObjects gameObject2 = new GameObjects();
            GameObjects gameObject3 = new GameObjects();
            GameObjects gameObject4 = new GameObjects();

            Character player = new Character();

            Raylib.InitWindow(ScreenHeight, ScreenWidth, "BALLS");
            Raylib.SetTargetFPS(60);

            gameObject1.CreateGameObject(ScreenWidth, ScreenHeight, 50, Color.GetColor);
            gameObject2.CreateGameObject(ScreenWidth-ScreenWidth, ScreenHeight-ScreenHeight, 50, Color.GetColor);
            gameObject3.CreateGameObject(ScreenWidth-ScreenWidth, ScreenHeight, 50,  Color.GetColor);
            gameObject4.CreateGameObject(ScreenWidth, ScreenHeight-ScreenHeight, 50,  Color.GetColor);

            player.CreateCharacter(BallPositionY, BallPositionX, BallRadius);


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                
                Movement.GetMovement();
                Raylib.DrawText("Move your character with the arrow keys!", 12, 12, 20, Color.BLACK);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }