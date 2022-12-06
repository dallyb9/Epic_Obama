using Raylib_cs;
using System.Numerics;

interface Shape {

    public string Name();
    public double Area();
    public Rectangle CollisionRect();
}