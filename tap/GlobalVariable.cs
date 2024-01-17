using System.Numerics;

namespace HelloWorldApplication;

public static class GlobalVariables
{
    public static float dt = 0.1f;

    public static string[,] PatternPlayer = new string[3, 3];
    public static string[,] PatternBill = new string[1, 1];
    public static string[,] PatternGuest = new string[2, 2];
    public static List<Beer> beers = new List<Beer>();

    public static float Distance(Vector2 v1, Vector2 v2)
    {
        return (float)Math.Sqrt(Math.Pow(v2.X - v1.X, 2) + Math.Pow(v2.Y - v1.Y, 2));
    }
    public static void InitializeGlobalVariables()
    {
        PatternPlayer = BuildTriangle3x3(LetterPlayer);
        PatternBill = Build1x1(LetterBill);
        PatternGuest = BuildRectangle2x2(LetterGuest);
    }

    public static string[,] BuildTriangle3x3(string content)
    {
        return new[,]
        {
            { "  ", content, "  " },
            { " |", content, "| " },
            { content, content, content }
        };
    }

    public static string[,] BuildRectangle2x2(string content)
    {
        return new[,]
        {
            { content },
            { content }
        };
    }

    public static string[,] Build1x1(string content)
    {
        return new[,] { { content } };
    }

    public static string LetterBill = "酒"; //1x1
    public static string LetterPlayer = "人"; //3x3
    public static string LetterGuest = "客"; //2x2
    public static string LetterEmpty = "  ";
}