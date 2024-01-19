using System.Numerics;

namespace HelloWorldApplication;



public class Customer
{
    public Vector2 pos;
    public string[,] pattern = GlobalVariables.PatternPlayer;
    protected int movespeed;

    public int liveflag = 1;
    public Customer(Vector2 Pos, int Movespeed)
    {
        pos = Pos;
        movespeed = Movespeed;
    }
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

    public void Update(){
        automove();
        getbeer();
    }
}

public class Player
{
    public Vector2 pos;
    public string[,] pattern;
    protected int movespeed;

    public Player(Vector2 Pos, int Movespeed)
    {
        pos = Pos;
        movespeed = Movespeed;
        pattern = GlobalVariables.PatternPlayer;
    }

    private void move(){
        bool isRunning = true;

        
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

    private void sendbeer()
    {
        Vector2 beerpos = new Vector2(1,0) + pos;
        int beerspeed = 1;
        Beer beer = new Beer(beerpos, beerspeed);
    }

    
    public void Update(){
        move();
    }
}

public class Beer
{
    public Vector2 pos;
    public string[,] pattern = GlobalVariables.PatternBill;
    protected int movespeed;

    public int liveflag;

    public Beer(Vector2 Pos, int Movespeed)
    {
        pos = Pos;
        movespeed = Movespeed;
    }

    private void automove(){
        pos += new Vector2(1,0) * movespeed;
    }

    
    public void Update(){
        automove();
    }

}