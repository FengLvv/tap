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
                GlobalVariables.InitializeGlobalVariables();
                RenderPipeline.OnStart();
            }

            /*
             static void StartRenderTimer()
            {
                System.Timers.Timer renderTimer = new System.Timers.Timer(50); // 设置渲染间隔
                renderTimer.AutoReset = true;
                renderTimer.Elapsed += (sender, e) => RenderPipeline.Update();
                GlobalVariables.player.Update();
                renderTimer.Enabled = true;
            }

            static void StartLogicTimer()
            {
                System.Timers.Timer logicTimer = new System.Timers.Timer(1000); // 设置逻辑更新间隔）
                logicTimer.AutoReset = true;
                logicTimer.Elapsed += (sender, e) => Logic.GenerateCustomer();
                logicTimer.Enabled = true;
            }

            */

            static void UpdateLoop()
            {
                System.Timers.Timer timer = new  System.Timers.Timer(50); // 创建一个间隔为0.1秒的定时器
                timer.AutoReset = true; // 设置定时器为自动重复
                timer.Elapsed += LoopEvent; // 绑定定时器事件处理方法
                timer.Enabled = true; // 启动定时器
                GlobalVariables.CurrentTime += GlobalVariables.dt;

                //update game objs
                GlobalVariables.player.Update();
                for(int i=0; i < GlobalVariables.beers.Count; i++){
                    Beer beer = GlobalVariables.beers[i];
                    beer.Update();
                }
  
                for(int i=0; i < GlobalVariables.customers.Count; i++){
                    Customer cust = GlobalVariables.customers[i];
                    cust.Update();
                }
            }
            static void LoopEvent(object source, ElapsedEventArgs e)
            {
                RenderPipeline.Update();
                Logic.GenerateCustomer();
            }

            //execute part
            
            StartLoop();
            UpdateLoop();
            Console.ReadKey(true);
            //while(true);
        }
    }
}