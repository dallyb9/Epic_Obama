using Raylib_cs;

class Rocks : Fallingobject
{
    string rock_template = "[]";
    int RockSize = 50;
    public void Draw()
    {
        //                                x,  y, size, color
        Raylib.DrawText($"{rock_template}", 12, 12, 20, Color.BLACK);
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, RockSize, RockSize, Color.BLUE);
    }
}