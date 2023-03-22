namespace MethodsExercise
{
    public class Program
    {

        //Exercise 1
        public static void Main(string[] args)
        {

            int answer = Calculations.Add(5, 5);
            Console.WriteLine(answer);

            answer = Calculations.Multiply(5, 5);
            Console.WriteLine(answer);

            answer = Calculations.Divide(50, 5);
            Console.WriteLine(answer);

            answer = Calculations.Subtract(7, 3);
            Console.WriteLine(answer);

            Calculations.AddWithParams(5, 5, 5, 5);
            Calculations.AddWithParams(5, 2, 5, 5, 5, 2, 1, 2);
            Methods.MadLib();

            Console.WriteLine(Calculations.AddWithParams(10, 2, 2, 5));
        }
    }
}
        