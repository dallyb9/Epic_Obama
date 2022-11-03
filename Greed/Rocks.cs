using Raylib_cs;

class Rocks: Player{
    string rock_template = "[]";
    var RockSize = 50;
    Raylib.DrawRectangleRec(RockSize, RockSize);
}