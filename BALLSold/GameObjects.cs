using Raylib_cs;
using System.Numerics;
class GameObjects{

    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);
    public void CreateGameObject(int X, int Y, int Radius, Color color) {
        // int objectRadius = 50;
        Raylib.DrawCircle(X,Y,Radius,color);
        Console.WriteLine("Making game circle");
    }

    virtual public void Draw() {
        // Base game objects do not have anything to draw
    }

    virtual public void Move() {
        Vector2 NewPosition = Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;
    }
}