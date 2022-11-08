using Raylib_cs;
class Gems{
    string gem_template = "*";
    public void Draw(){
        Raylib.DrawText($"{gem_template}", 12, 12, 20, Color.BLACK);
    }

}