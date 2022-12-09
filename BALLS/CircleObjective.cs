using Raylib_cs;
using System.Numerics;

class CircleObjective: ColoredObject{

    public bool Win{get; set;}
    int Radius;
    public CircleObjective(int radius, Color color): base(color) {
        var objColor = Color.WHITE;
        Radius = radius;
        Win = false;
    }
    
    override public void Draw() {
        Raylib.DrawCircleV(Position, Radius, Color);
    }

    public Rectangle Rect()
    {
        return new Rectangle(Position.X, Position.Y, 50, 53);
    }
    public Vector2 Circle()
    {
        return new Vector2(Position.X, Position.Y);
    }

}