using Raylib_cs;
using System.Numerics;

class ColoredObject: GameObject {
    public Color Color { get; set; }

    public ColoredObject(Color color) {
        Color = color;
    }
}