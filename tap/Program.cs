using System;
using System.Timers;
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

            static void UpdateLoop()
            {
                System.Timers.Timer timer = new  System.Timers.Timer(50); // 创建一个间隔为0.1秒的定时器
                timer.AutoReset = true; // 设置定时器为自动重复
                timer.Elapsed += LoopEvent; // 绑定定时器事件处理方法
                timer.Enabled = true; // 启动定时器
            }
            static void LoopEvent(object source, ElapsedEventArgs e)
            {
                RenderPipeline.Update();
            }
            
            
            //execute part
            StartLoop();
            UpdateLoop();
            Console.ReadKey();
        }
    }
}