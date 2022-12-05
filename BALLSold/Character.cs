using Raylib_cs;
using System.Numerics;
class Character: Colors {
    public void CreateCharacter(int BallPositionY, int BallPositionX, float BallRadius){
        var BallPosition = new Vector2(BallPositionY, BallPositionX);
        Raylib.DrawCircleV(BallPosition, BallRadius, Color.MAROON);
    }
}