class ObjectColor
{

    List<string> colorlist = new List<string> { "RED", "BLUE", "YELLOW", "GREEN" };
    public string ChooseColor()
    {
        var Random = new Random();
        var randomNum = Random.Next(0, 3);
        string color = colorlist[randomNum];
        return color;
    }
}