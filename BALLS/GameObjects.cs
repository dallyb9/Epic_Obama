using Raylib_cs;
using System.Numerics;
class GameObjects{

public void CreateGameObject(int X, int Y, int Radius, string color){
// int objectRadius = 50;
Raylib.DrawCircle(X,Y,Radius,color);
}

}