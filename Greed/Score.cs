using Raylib_cs;

class Score{
    int score = 0;
    int addScore(){
        score = score + 100;
        return score;
    }
    int subtractScore(){
        score =  score - 100;
        return score;
    }

    void checkWin(){
        if (score >= 1000){
            Raylib.DrawText("YOU WIN!", 12, 12, 20, Color.BLACK);
            end();
        }
    }
}