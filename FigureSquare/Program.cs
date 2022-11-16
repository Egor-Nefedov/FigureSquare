
namespace FigureSquare
{
    class Program
    {
        static void Main()
        {
            var NumbersString = Console.ReadLine();
            string[] Numbers = NumbersString.Split(' ');
            var Count = Numbers.Length;
            Console.WriteLine(Count);
            double Square;
            if (Count == 1)
            {
                var Radius = Convert.ToDouble(Numbers[0]);
                Circle circle = new Circle(Radius);
                Square = circle.CircleSquare();
            }
            else if(Count == 3)
            {
                var first = Convert.ToDouble(Numbers[0]);   
                var second = Convert.ToDouble(Numbers[1]);
                var third = Convert.ToDouble(Numbers[2]);
                Triangle triangle = new Triangle(first, second, third);
                Square = triangle.TriangleSquare();
            }
            else
            {
               Square = 0;
            }
            
            
            Console.WriteLine(Square);
        }

        private static void elseif(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
