using Raylib_cs;

class Rocks : Fallingobject
{
    string rock_template = "[]";
    var RockSize = 50;
    override public void Draw()
    {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, RockSize, RockSize, Color);
    }
}