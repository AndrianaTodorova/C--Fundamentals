using System;
using System.Text;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double Length
    {
        get { return this.length; }
        set { this.length = value; }
    }
    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }
    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public double GetSurfaceArea()
    {
        return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
    }

    public double GetLateralSurface()
    {
        return (2 * this.length * this.height) + (2 * this.width * this.height);
    }

    public double GetVolume()
    {
        return this.length * this.width * this.height;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Surface Area - {GetSurfaceArea():f2}");
        sb.AppendLine($"Lateral Surface Area - {GetLateralSurface():f2}");
        sb.Append($"Volume - {GetVolume():f2}");
        return sb.ToString();
        
    }
}