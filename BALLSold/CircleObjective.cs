using Raylib_cs;
using System.Numerics;

class CircleObjective: Colors {

    int Radius;
    public GameCircle(int radius, Color color): base(color) {
        Radius = radius;
    }

    override public void Draw() {
        Raylib.DrawCircleV(Position, Radius, Color);
    }
}
