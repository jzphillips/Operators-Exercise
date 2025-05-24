namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;

            int quotient = a / b; 
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("What is the radius of the circle? Input Here");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}.");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
    }
}
