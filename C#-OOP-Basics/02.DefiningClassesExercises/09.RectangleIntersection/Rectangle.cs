using System;

public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double horizontal;
    private double vertical;

    public Rectangle(string id, double width, double height, double horizontal, double vertical)
    {
        this.id = id;
        this.width = Math.Abs(width);
        this.height = Math.Abs(height);
        this.horizontal = Math.Abs(horizontal);
        this.vertical = Math.Abs(vertical);
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
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
    public double Horizontal
    {
        get { return this.horizontal; }
        set { this.horizontal = value; }
    }
    public double Vertical
    {
        get { return this.vertical; }
        set { this.vertical = value; }
    }

    public bool RectangleIntersect(Rectangle rect)
    {
        if (rect.Horizontal + rect.Width >= this.Horizontal &&
            rect.Horizontal <= this.Horizontal + this.Width &&
            rect.Vertical >= this.Vertical - this.Height &&
            rect.Vertical - rect.Height <= this.Vertical)
        {
            return true;
        }

        return false;
    }
}