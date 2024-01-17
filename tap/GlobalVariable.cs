namespace HelloWorldApplication;

public static class GlobalVariables
{
    public static float dt = 0.1f;

    public static string[,] PatternPlayer = BuildTriangle3x3(LetterPlayer);
    public static string[,] PatternBill = Build1x1(LetterBill);
    public static string[,] PatternGuest = BuildRectangle2x2(LetterGuest);

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
            { content, content },
            { content, content },
            { content, content }
        };
    }
    public static string[,] Build1x1(string content)
    {
        return new [,] { { content } };
    }

    public static string LetterBill = "酒"; //1x1
    public static string LetterPlayer = "人"; //3x3
    public static string LetterGuest = "客"; //2x2
    public static string LetterEmpty = "  ";
}