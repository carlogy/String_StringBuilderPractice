using System;
namespace String_StringBuilderPractice
{
	public class DuplicateChecker
	{
		public static void CheckDuplicates()
		{
			Console.Write("Enter a few numbers separated by a hyphen and I'll check for duplicates: ");
			var input = Console.ReadLine();

			var NumbersArray = input.Split("-");
			

			

			
			if (string.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Program has ended");
				Console.ReadLine();
			}
			
			foreach (var number in NumbersArray)
			{
				var Numbers = Array.LastIndexOf(NumbersArray, number);

				if (Numbers != Array.IndexOf(NumbersArray, number))
				{
					Console.WriteLine("Duplicate");
					break;
				}
					
			}

          




        }
	}
}

