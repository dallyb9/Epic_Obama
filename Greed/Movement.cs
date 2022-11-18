using Raylib_cs;
using System.Numerics;
class Movement : Player
{
    var PlayerRectangle = new Player();
    var MovementSpeed = 5;

<<<<<<< HEAD
    public void playerMovement()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            PlayerRectangle.x += MovementSpeed;
=======
// Could we use this for the movement of the rocks and gems
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);

    public void Move() {
        Vector2 NewPosition = this.Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        this.Position = NewPosition;
    }
    

static void playerMovement(){
    var MovementSpeed = 5;
    var PlayerRectangle = new Player();
    var ScreenHeight = 400;
    var ScreenWidth = 800;
    var PlayerRectangle = new Vector2(ScreenHeight / 2, ScreenWidth / 2);

    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
        PlayerRectangle.x += MovementSpeed;
>>>>>>> 652c1512d5c45607c1acbda9070392329add51c8
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            PlayerRectangle.x -= MovementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            PlayerRectangle.y -= MovementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            PlayerRectangle.y += MovementSpeed;
        }
        return PlayerRectangle;
    }
}