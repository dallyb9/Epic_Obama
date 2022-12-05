using Raylib_cs;
using System.Numerics; 

class Movement{
    public int GetMovement(int BallPositionY, int BallPositionX, int ScreenHeight, int ScreenWidth, int BallMovementSpeed)
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && BallPositionX != ScreenWidth) {
            BallPositionX += BallMovementSpeed;
            return BallPositionX;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && BallPositionX != 0) {
            BallPositionX -= BallMovementSpeed;
            return BallPositionX;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && BallPositionY != ScreenHeight) {
            BallPositionY -= BallMovementSpeed;
            return BallPositionY;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && BallPositionY != 0) {
            BallPositionY += BallMovementSpeed;
            return BallPositionY;
        }
    }
}