using Raylib_cs;
using System.Numerics;
class Movement: Player {
    
    

static void playerMovement(){
       var MovementSpeed = 5;
       var PlayerRectangle = new Player();
    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
        PlayerRectangle.x += MovementSpeed;
        }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
        PlayerRectangle.x -= MovementSpeed;
        }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
        PlayerRectangle.y -= MovementSpeed;
        }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
        PlayerRectangle.y += MovementSpeed;
        }
    }
}