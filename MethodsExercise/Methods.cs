using System;
namespace MethodsExercise
{
	public class Methods
	{
		public static void MadLib()
		{
			Console.WriteLine("Enter a kind of animal: ");
			string animal = Console.ReadLine();

			Console.WriteLine("Enter a color: ");
			string color = Console.ReadLine();

			Console.WriteLine("Enter a type of fruit: ");
			string fruit = Console.ReadLine();

			Console.WriteLine("Enter a type of shape: ");
			string shape = Console.ReadLine();

			Console.WriteLine($"Who lives in a {fruit} under the sea? \n" +
			$"Absorbant and {color} is he. If nautical \n +" +
			$"nonsense be something you wish? Then drop on the deck \n +" +
			$"and flop like a {animal}. Ready?  Spongebob {shape} pants!");
        }
    }
}

