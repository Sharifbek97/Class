namespace Class;

public class Triangle
{
    public double Perimeter(double a, double b, double c)
    {
        return a + b + c;
        
    }
    public double Area(double a, double b, double c)
    {
        return Math.Sqrt(((a + b + c)/2)*(((a + b + c)/2)-a)*(((a + b + c)/2)-b)*(((a + b + c)/2)-c));
        
    }
}