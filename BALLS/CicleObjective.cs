using Raylib_cs;
using System.Numerics;

class CicleOjbective: ColoredObject {

    int Radius;
    public CicleOjbective(int radius, Color color): base(color) {
        Radius = radius;
    }

    override public void Draw() {
        Raylib.DrawCircleV(Position, Radius, Color);
    }
}