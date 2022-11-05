class Fallingobject
{
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);
    public void movedown()
    {
        Vector2 NewPosition = Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;
    }
    int getRandomPostition()
    {
        Random rnd = new Random();
        int num = (rnd.Next(ScreenWidth));//returns random integers < ScreenWidth
        var randomposition = new Vector2(0, num);
        Return randompostition;
    }
}