using System.Runtime.ConstrainedExecution;

namespace HelloWorldApplication;

public static class RenderPipeline
{
    public static List<GameObj> _objs;

    public static String[,] canvas;

    public static void OnStart()
    {
        ClearScreen();
    }

    public static void ClearScreen()
    {
        canvas = new String[20, 20];
        for (int i = 0; i < canvas.GetLength(0); i++)
        {
            for (int j = 0; j < canvas.GetLength(1); j++)
            {
                canvas[i, j] = "1";
            }
        }
    }

    public static void RenderCanvas()
    {
        for (int h = 0; h < canvas.GetLength(1); h++)
        {
            for (int v = 0; v < canvas.GetLength(0); v++)
            {
                var content = canvas[v, h];
                Console.WriteLine(content);
            }

            Console.WriteLine("\n");
        }

 
    }
}

