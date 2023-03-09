namespace MethodsExercise
{
    public class Program
    {

        //Exercise 1
        public static void Main(string[] args)
        {
            int amountOfCars = Sum(2, 6);
            int Samp = Multiply(60, 2);

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }


        public static void MadLib()
        {
            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            //string interpolation with $
            Console.WriteLine($"Hi, {userName}, what is your favorite color?");
            var faveColor = Console.ReadLine();

            Console.WriteLine($"{faveColor} is an awesome color! What is your favorite animal?");
            var faveAnimal = Console.ReadLine();

            Console.WriteLine("Excellent! Now, what is your fvorite band?");
            var faveBand = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {faveColor}");
            Console.WriteLine($"Favorite Animal: {faveAnimal}");
            Console.WriteLine($"Favorite Band: {faveBand}");

            Console.WriteLine($"One day, {userName} was going to the Vet clinic wearing a {faveColor} dress." +
            $"On getting there, she saw a {faveAnimal} looking at her through one of the windows in the Vet clinic." +
            $"As she walked into the Vet clinic, she heard her {faveBand} playing on the radio nearby. {userName} was amazed to be hearing that song in a Vet clinic.");

        }


        //Exercise 2
        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;

            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            int multiply = num1 * num2;

            return num1 * num2;
        }


        //Challenge mode using the params keyword:
        public static int Multiply(params int[] nums)
        {
            int product = 1;

            foreach (int x in nums)
            {
                product *= x;
            }

            return product;

        }
    }
}
        