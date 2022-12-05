using Raylib_cs;
using System.Numerics;



static class Program
{

    public static void Main()
    {
        var ScreenHeight = 800;
        var ScreenWidth = 800;
        int BallPositionX = (ScreenWidth / 2);
        int BallPositionY = (ScreenHeight / 2);
        int BallMovementSpeed = 1;
        float BallRadius = 50;

        //GameObjects gameObject1 = new GameObjects();
        GameObjects gameObject2 = new GameObjects();
        GameObjects gameObject3 = new GameObjects();
        GameObjects gameObject4 = new GameObjects();

        GameObjects player = new GameObjects();

        var Character = new Character();

        var Objects = new List<GameObjects>();

        Raylib.InitWindow(ScreenHeight, ScreenWidth, "BALLS");
        Raylib.SetTargetFPS(60);

        //gameObject1.CreateGameObject((ScreenWidth/2), (ScreenHeight/2), 50, Color.BEIGE);
        var gameObject1 = new GameObjects.CreateGameObject((ScreenWidth / 2), (ScreenHeight / 2), 50, Color.BEIGE);
        Objects.Add(gameObject1);
        // gameObject2.CreateGameObject(ScreenWidth-ScreenWidth, ScreenHeight-ScreenHeight, 50, Colors.GetColor());
        // gameObject3.CreateGameObject(ScreenWidth-ScreenWidth, ScreenHeight, 50,  Color.GetColor);
        // gameObject4.CreateGameObject(ScreenWidth, ScreenHeight-ScreenHeight, 50,  Color.GetColor);

        //Character.CreateCharacter(BallPositionY, BallPositionX, BallRadius);
        Objects.Add(player);


        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            foreach (var obj in Objects)
            {
                obj.Draw();
            }
            //gameObject1.CreateGameObject((ScreenWidth/2), (ScreenHeight/2), 50, Color.BEIGE);
            //Character.CreateCharacter(BallPositionY, BallPositionX, BallRadius);

            Movement.GetMovement(BallPositionY, BallPositionX, ScreenHeight, ScreenWidth, BallMovementSpeed);
            Raylib.DrawText("Move your character with the arrow keys!", 12, 12, 20, Color.BLACK);

            Raylib.EndDrawing();

            foreach (var obj in Objects)
            {
                obj.Move();
            }
        }

        Raylib.CloseWindow();
    }
}