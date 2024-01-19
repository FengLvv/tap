using System.Timers;
using System.Numerics;
namespace HelloWorldApplication;

public class Logic
{
    private static System.Timers.Timer _timer;
    private static Random _random = new Random();

    private static int i = 0;
    
    public static void GenerateCustomer()
    {
        if(GlobalVariables.CurrentTime - i*1000 > 0){
            i += 1;
            Customer newCustomer = new Customer(new Vector2(_random.Next(5, 10), 20), 1);
            GlobalVariables.customers.Add(newCustomer);
        }
    }
        
}