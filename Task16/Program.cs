namespace Task16
{
    class Program
    {
        public static void Main()
        {
            Circle circle = new Circle();
            circle.SetRadius(5);
            Console.WriteLine("Radius: " + circle.GetRadius());
            Console.WriteLine("Area: " + circle.GetArea());
            Console.WriteLine("Perimeter: " + circle.GetPerimeter());
        }
    }
    

}