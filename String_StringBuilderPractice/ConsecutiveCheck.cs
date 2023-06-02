using System;
namespace String_StringBuilderPractice
{
	public class ConsecutiveCheck
	{
		public static void checker()
		{
			Console.Write("Input a series of numbers separated by a hyphen: ");
			var input = Console.ReadLine();

			var numbers = input.Split(separator: "-");

            bool areConsecutive = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                int nextNumber = int.Parse(numbers[i + 1]);

                if (currentNumber + 1 != nextNumber)
                {
                    areConsecutive = false;
                    break;
                }
            }

            // Display the result.
            if (areConsecutive)
            {
                Console.WriteLine("The numbers are consecutive.");
            }
            else
            {
                Console.WriteLine("The numbers are not consecutive.");
            }


            Console.ReadLine();
		}
	}
}

