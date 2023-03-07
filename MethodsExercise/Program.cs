namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Exercise 1
            //Name: Michael
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles

            Console.WriteLine("Hello - What is your first name?"); //output
            var userName = Console.ReadLine(); //input

            Console.WriteLine($"Hi, {userName}. What is your favorite color?"); //output
            var color = Console.ReadLine(); //input

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?"); //output
            var animal = Console.ReadLine(); //input

            Console.WriteLine("Excellent! Now, what is your fvorite band?"); //output
            var band = Console.ReadLine(); //input

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

        }
    }
}
