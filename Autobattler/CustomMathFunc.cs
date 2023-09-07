using Godot;
using System;

public class CustomMathFunc {
    public static Vector2 DegreesToUnitVector(double angle)
{
    double radians = Math.PI * angle / 180.0;
    double x = Math.Cos(radians);
    double y = Math.Sin(radians);
    return new Vector2((float)x, (float)y);
}
}

