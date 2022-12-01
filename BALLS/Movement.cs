using Raylib_cs;
using System.Numerics; 

static class Movement{


    static void GetMovement(int BallPositionY, int BallPositionX, int ScreenHeight, int ScreenWidth)
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT && BallPositionX != ScreenWidth)) {
            BallPositionX += BallMovementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT && BallPositionX != 0)) {
            BallPositionX -= BallMovementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP && BallPositionY != ScreenHeight)) {
            BallPositionY -= BallMovementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN && BallPositionY != 0)) {
            BallPositionY += BallMovementSpeed;
        }
        if (BallPositionY == ScreenHeight || BallPositionY <= ScreenHeight){
            return;
        }
    }
}