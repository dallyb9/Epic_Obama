// class GameSquare: ColoredObject {
//     int Side;

//     public GameSquare(int side, Color color): base(color) {
//         Side = side;
//     }

//     override public void Draw() {
//         Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Side, Side, Color);
//     }
// }
// class GameRectangle: ColoredObject {

//     int Width;
//     int Height;

//     public GameRectangle(int w, int h, Color color): base(color) {
//         Width = w;
//         Height = h;
//     }

//     override public void Draw() {
//         Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Width, Height, Color);
//     }
// }

// class GameCircle: ColoredObject {

//     int Radius;
//     public GameCircle(int radius, Color color): base(color) {
//         Radius = radius;
//     }

//     override public void Draw() {
//         Raylib.DrawCircleV(Position, Radius, Color);
//     }
// }

// class GameText: ColoredObject {
//     string Text;

//     public GameText(string text, Color color): base(color) {
//         Text = text;
//     }

//     public override void Draw() {
//         Raylib.DrawText(this.Text, (int)Position.X, (int)Position.Y, 20, this.Color);
//     }
// }