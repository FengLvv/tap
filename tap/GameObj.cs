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
