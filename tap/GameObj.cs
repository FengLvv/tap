using System.Numerics;

namespace HelloWorldApplication;

public abstract class GameObj
{
    protected Vector2 pos;
    protected int[,] pattern; 
    protected void OnStart() { }
    protected void Update(){}
}