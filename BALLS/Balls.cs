using Raylib_cs;
using System.Numerics;
using System;  
using System.Threading.Tasks;

class Balls
{
    RandomSelector RandomSelector = new RandomSelector();
    public void Play()
    {
        var ScreenHeight = 500;
        var ScreenWidth = 500;

        //Time time = new Time();
        // bool GameOver = false;

        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Shape Land");
        Raylib.SetTargetFPS(60);

        // Create player
        var Player = new Player();

        string winColor = "Unselected color";
        int score = 0;
        int timeRemain = 0;

        //Create game text on screen
        var scoreText = new GameText($"Score: {score}", Color.WHITE);
        var timerText = new GameText($"Time left: {timeRemain}", Color.WHITE);
        // creates new empty list of GameObjects
        var Objects = new List<GameObject>();

        Player.Position = new Vector2(ScreenWidth / 2, ScreenHeight / 2);

        scoreText.Position = new Vector2(20, 20);
        timerText.Position = new Vector2((ScreenWidth / 2) - 60, 50);

        int oldscore = -1;
        int winObj = 0;
        List<string> colorList = new List<string>();
        DateTime newTimer = DateTime.Now;
        //var timerEnd = newTimer.AddSeconds(10);
        DateTime timerEnd = DateTime.Now.AddSeconds(10);
        // DateTime remainingTime = DateTime.Now.AddSeconds(10);

        // MAIN WHILE LOOP
        while (!Raylib.WindowShouldClose())
        {
            // Whenever you make a point, delete and remake everything.
            if (oldscore != score)
            {
                // remove all objects from 'Objects' list
                Objects = new List<GameObject>();
                //List<string> colorList = RandomSelector.MakeColorList();
                colorList = RandomSelector.MakeColorList();


                // Winning obj
                winObj = RandomSelector.RdmNum();

                // loop 4 times
                for (int i = 0; i < 4; i++)
                {
                    var circleColor = Color.WHITE;
                    int xcoordinate = 0;
                    int ycoordinate = 0;

                    switch (colorList[i])
                    {
                        case "BLUE":
                            circleColor = Color.BLUE;
                            break;
                        case "GREEN":
                            circleColor = Color.GREEN;
                            break;
                        case "RED":
                            circleColor = Color.RED;
                            break;
                        case "YELLOW":
                            circleColor = Color.YELLOW;
                            break;
                        default:
                            Console.WriteLine("Color select error");
                            break;
                    }
                    switch (i)
                    {
                        case 0:
                            // top left
                            xcoordinate = 0;
                            ycoordinate = 0;
                            break;
                        case 1:
                            // top right
                            xcoordinate = ScreenWidth;
                            ycoordinate = 0;
                            break;
                        case 2:
                            // bottom left
                            xcoordinate = 0;
                            ycoordinate = ScreenHeight;
                            break;
                        case 3:
                            // bottom right
                            xcoordinate = ScreenWidth;
                            ycoordinate = ScreenHeight;
                            break;
                        default:
                            Console.WriteLine("i out of range in loop");
                            break;
                    }

                    // CicleObjective(radius, color);
                    var circle = new CircleObjective(200, circleColor);

                    // If i = winning Objective number
                    if (i == winObj)
                    {
                        circle.Win = true;
                        winColor = colorList[i];
                    }
                    circle.Position = new Vector2(xcoordinate, ycoordinate);
                    Objects.Add(circle);

                    // var circle = new CicleObjective(RandomSelector.RdmNum(), circleColor);
                    // circle.Position = RandomSelector.RandomPosition(xcoordinate, ycoordinate);
                }
                var winColorText = new GameText($"Find: {winColor}", Color.WHITE);
                winColorText.Position = new Vector2((ScreenWidth / 2) - 60, 100);

                scoreText = new GameText($"Score: {score}", Color.BLACK);
                scoreText.Position = new Vector2(20, 20);

                Objects.Add(Player);
                Objects.Add(winColorText);
                Objects.Add(scoreText);
            }

            string remainingTime = (timerEnd - newTimer).ToString("ss");
            timerText = new GameText($"Time left: {remainingTime}", Color.WHITE);
            timerText.Position = new Vector2((ScreenWidth / 2) - 60, 50);
            Objects.Add(timerText);
            // remove all objects from 'Objects' list
            //Objects = new List<GameObject>();

            // reset player position
            //Player.Position = new Vector2(ScreenWidth / 2, ScreenHeight - 100);
            oldscore = score;
            if (newTimer >= timerEnd){
                    Console.WriteLine("GAME OVERRRRRRRRRRRRRRRRRRRRRRR");
                    Objects.Remove(Player);
                }
            newTimer = DateTime.Now;
        
            Console.WriteLine($"newTimer: {newTimer.ToString("ss")}");
            Console.WriteLine($"timerEnd: {timerEnd.ToString("ss")}");
          
            
            
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            //Time.Timer();

            // Draw all of the objects in their current location
            foreach (var obj in Objects)
            {
                obj.Draw();
            }

            // Check if link is on any of the shapes
            foreach (var obj in Objects)
            {
                // if (DateTime.Now == timerEnd){
                //     Console.WriteLine("DEATH");
                // }
                if (obj is CircleObjective)
                {
                    var shape = (CircleObjective)obj;
                    if (Raylib.CheckCollisionCircleRec(obj.Position, 200, Player.Rect()))
                    {

                        Console.WriteLine("Collided with sphere");
                        // Check obj color
                        if (shape.Win)
                        {
                            // Reset player position
                            Player.Position = new Vector2(ScreenWidth / 2, ScreenHeight / 2);
                            Console.WriteLine("Collided with Winning sphere");
                            score++;
                            if (score < 10){
                            timerEnd = DateTime.Now.AddSeconds(10-(.7*score));
                            }
                            else {
                                timerEnd = DateTime.Now.AddSeconds(1.4);
                            }
                        }
                        //Raylib.DrawText("Nice", 100, 100, 20, Color.WHITE);

                        // Add 1 to score
                        Console.WriteLine(score);
                    }
                }
            }

            Objects.Remove(timerText);



            Raylib.EndDrawing();

            // Move all of the objects to their next location
            foreach (var obj in Objects)
            {
                obj.Move();
            }
        }

        Raylib.CloseWindow();
    }
}