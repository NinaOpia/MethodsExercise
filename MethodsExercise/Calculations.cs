using System;
namespace MethodsExercise
{
    public class Calculations
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        //Exercise 2
        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;

            return num1 + num2;
        }


        //Challenge mode using the params keyword:
        public static int AddWithParams(params int[] nums)
        {
            int sum = 0;

            foreach (int x in nums)
            {
                sum *= x;
            }

            return sum;
        }

    }   
}

