using Raylib_cs;
using System.Numerics;

interface Shape {

    public string Name();
    public double Area();
    public Rectangle CollisionRect();

    // public Rectangle Rect()
    // {
    //     return new Rectangle(Position.X, Position.Y, 50, 53);
    // }
}