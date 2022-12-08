using Raylib_cs;
using System.Numerics;
public class RandomSelector {
    Random Rdm = new Random();
    List<string> colorList = new List<string>();

    // public Vector2 RandomPosition(int height, int width) {
    //     var x = Rdm.Next(0, width);
    //     var y = Rdm.Next(0, height);
    //     return new Vector2(x, y);
    // }

    public int RdmNum() {
        return Rdm.Next(0, 3);
    }

    public List<string> MakeColorList() {
        List<string> unsortedColorList = new List<string>() { "BLUE", "GREEN",  "RED", "YELLOW" };
        while(unsortedColorList.Count > 0){
            int randIndex = Rdm.Next(unsortedColorList.Count);
            colorList.Add(unsortedColorList[randIndex]);
            unsortedColorList.RemoveAt(randIndex);
            }
        return colorList;
    }
}