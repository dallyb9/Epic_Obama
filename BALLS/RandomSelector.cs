using Raylib_cs;
using System.Numerics;
public class RandomSelector
{
    Random Rdm = new Random();

    public int RdmNum()
    {
        return Rdm.Next(0, 3);
    }
    public List<string> MakeColorList()
    {
        // empty list to append colors randomly to it
        List<string> colorList = new List<string>();
        // List I'm getting the colors from:
        List<string> unsortedColorList = new List<string>() { "BLUE", "GREEN", "RED", "YELLOW" };
        while (unsortedColorList.Count > 0)
        {
            int randIndex = Rdm.Next(unsortedColorList.Count);
            colorList.Add(unsortedColorList[randIndex]);
            unsortedColorList.RemoveAt(randIndex);
        }
        return colorList;
    }
}