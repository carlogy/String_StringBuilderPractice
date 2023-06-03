using System;
namespace String_StringBuilderPractice
{
	public class TimeChecker
	{
		public static void TimeConverter()
		{
			Console.Write("Enter a time in a 24 hour format (e.g. 13:00): ");

			var input = Console.ReadLine();

			try
			{
				var Time = Convert.ToDateTime(input);
                Console.WriteLine(Time.ToShortTimeString());
            }
			catch (FormatException)
			{
				Console.WriteLine("Invalid Time");
			}

			
			

			
		}
	}
}

