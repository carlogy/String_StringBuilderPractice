using System;
using System.Globalization;
namespace String_StringBuilderPractice
{
	public class PascalCase_converter
	{
		public static void Input()
		{
			Console.Write("Enter a string of words to convert to PascalCase: ");

			var Input = Console.ReadLine();


			var WordArray = Input.ToLower().Split(" ");
			TextInfo TI = CultureInfo.CurrentCulture.TextInfo;
			foreach (var word in WordArray)
			{
				Console.Write(TI.ToTitleCase(word));


			}




		}
	}
}

