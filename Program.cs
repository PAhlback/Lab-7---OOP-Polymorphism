namespace Lab_7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();
            Geometry circle = new Circle();
            Geometry parallelogram = new Parallelogram();
            Geometry ellipse = new Ellipse();

            Console.WriteLine($"Area rectangle: {rectangle.Area()}");
            Console.WriteLine($"Area square: {square.Area()}");
            Console.WriteLine($"Area circle: {circle.Area().ToString("0.##")}");
            Console.WriteLine($"Area parallelogram: {parallelogram.Area()}");
            Console.WriteLine($"Area ellipse: {ellipse.Area().ToString("0.##")}");
        }
    }
}