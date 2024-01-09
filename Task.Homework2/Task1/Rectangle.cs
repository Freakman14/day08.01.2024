public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
    public int GetPerimeter()
    {
        return (Width + Height) * 2;
    }
}