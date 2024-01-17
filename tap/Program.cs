using System;

namespace HelloWorldApplication
{
    /* 类名为 HelloWorld */
    class MainLoop
    {
        static void Main(string[] args)
        {
            static void StartLoop()
            {
                RenderPipeline.OnStart();
            }
            StartLoop();

            var canvas = RenderPipeline.canvas;
    
            Console.ReadKey();
      
        }
    }
}

public static class GlobalVariables{
    public static float dt = 0.1f;

}