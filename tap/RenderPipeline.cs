using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace HelloWorldApplication;

public static class RenderPipeline
{
    static string _empty = GlobalVariables.LetterEmpty;

    public static List<GameObj> _objs;

    public static String[,] canvas;
    private static int canvasSize = 25;
    private static int blankSize = 2;

    private static void InitCanvasContent(string content)
    {
        canvas = new String[canvasSize, canvasSize];
        for (int i = 0; i < canvas.GetLength(0); i++)
        {
            for (int j = 0; j < canvas.GetLength(1); j++)
            {
                canvas[i, j] = content;
            }
        }
    }

    private static void AddBlankLines(int lines)
    {
        for (int i = 0; i < lines; i++)
        {
            Console.WriteLine();
        }
    }

    public static void OnStart()
    {
        AddBlankLines(100);
        InitCanvasContent(_empty);
    }

    public static void Update()
    {
        List<int> a = new();
        InitCanvasContent(_empty);
        string[,] pattern = GlobalVariables.PatternGuest;
        Vector2 pos = new Vector2(10, 10);
        WritePatternOnCanvas(pattern, pos);
        RenderCanvas();
    }
    
    private static void WritePatternOnCanvas(string[,] pattern, Vector2 pos)
    {
        int h = pattern.GetLength(0);
        int v = pattern.GetLength(1);
        if (v == 3&&h==3) 
        {
            //渲染三角形，3x3
            for (int i =0 ; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Vector2 renderPos = pos + new Vector2(i-1, j-1);
                    canvas[(int)renderPos.X, (int)renderPos.Y]=pattern[i,j];
                }
            }
        }
        else if (v==2&&h==2)
        {
            //渲染正方形，2x2
            for (int i =0 ; i <2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Vector2 renderPos = pos + new Vector2(i-1, j);
                    canvas[(int)renderPos.X, (int)renderPos.Y]=pattern[i,j];
                }
            }
        }
        else if (v==1&&h==2)
        {
            //渲染正方形，2x2
            for (int i =0 ; i <2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Vector2 renderPos = pos + new Vector2(i-1, j);
                    canvas[(int)renderPos.X, (int)renderPos.Y]=pattern[i,j];
                }
            }
        }
        else if (pattern.Length == 1)
        {
            canvas[(int)pos.X, (int)pos.Y]=pattern[0,0];
        }
    }

    static void RenderCanvas()
    {
        AddBlankLines(blankSize);
        for (int h = 0; h < canvas.GetLength(0); h++)
        {
            //长度为列数的数组
            String line = "";
            for (int v = 0; v < canvas.GetLength(1); v++)
            {
                line = line + canvas[h, v];
            }
            Console.WriteLine(line);
        }

        AddBlankLines(blankSize);
    }
}