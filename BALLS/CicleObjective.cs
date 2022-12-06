using Raylib_cs;
using System.Numerics;

class CicleObjective: ColoredObject {

    int Radius;
    public CicleObjective(int radius, Color color): base(color) {
        Radius = radius;
    }

    override public void Draw() {
        Raylib.DrawCircleV(Position, Radius, Color);
    }
}