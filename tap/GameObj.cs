using System.Numerics;

namespace HelloWorldApplication;

public abstract class GameObj
{
    protected Vector2 pos;
    protected float[,] pattern; 
    protected int movespeed;
    protected void OnStart() { }
    protected void Update(){}
}

public class Customer::GameObj
{
    private int liveflag;

    private void automove(){
        pos += vector2(-1,0) * movespeed;
    }

    private void getbeer(){
        liveflag = 0;
    }

}

public class Player::GameObj
{
    private void move(){
        if (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.W:
                    pos += new Vector2(0, -1) * movespeed;
                    break;
                case ConsoleKey.A:
                    pos += new Vector2(-1, 0) * movespeed;
                    break;
                case ConsoleKey.S:
                    pos += new Vector2(0, 1) * movespeed;
                    break;
                case ConsoleKey.D:
                    pos += new Vector2(1, 0) * movespeed;
                    break;

                case ConsoleKey.L:
                    sendbeer();
                    break;
            }
        }
    }

    private void sendbeer(){

        Beer beer = new Beer(pos, );
    }
}

public class Beer::GameObj(){
    
}