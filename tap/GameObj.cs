using System.Numerics;

namespace HelloWorldApplication;


public abstract class GameObj
{
    private Vector2 pos;
    private string[,] pattern; 
    private int movespeed;
    private void Update(){}
}

public class Customer:GameObj
{
    protected Vector2 pos;
    protected string[,] pattern = GlobalVariables.PatternPlayer;
    protected int movespeed;

    private int liveflag;
    protected void automove(){
        pos += new Vector2(-1,0) * movespeed;
    }
    protected void getbeer(){
        for(int i=0; i < GlobalVariables.beers.Count; i++){
            Beer beer = GlobalVariables.beers[i];
            float distance = GlobalVariables.Distance(beer.pos, pos);
            if(distance < 0.5){
                liveflag = 0;
                beer.liveflag = 0;
            }
        }
    }

    protected void Update(){
        automove();
        getbeer();
    }
}

public class Player:GameObj
{
    protected Vector2 pos;
    protected string[,] pattern = GlobalVariables.PatternPlayer;
    protected int movespeed;

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

        Beer beer = new Beer();
    }

    
    protected void Update(){
        move();
    }
}

public class Beer:GameObj
{
    public Vector2 pos;
    protected string[,] pattern;
    protected int movespeed;

    public int liveflag;

    private void automove(){
        pos += new Vector2(1,0) * movespeed;
    }

    
    protected void Update(){
        automove();
    }

}