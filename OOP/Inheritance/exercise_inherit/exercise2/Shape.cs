﻿namespace exercise2;

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}
public class Circle : Shape
{
    public override void Draw()
    {
        base.Draw();
    }
}
