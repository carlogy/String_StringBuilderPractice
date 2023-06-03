using System;
using System.Linq;

namespace String_StringBuilderPractice
{
	public class VowelCounter
	{
		public static void vowels()
		{
			Console.Write("Enter a word to count its vowels: ");
			var input = Console.ReadLine();


			var CharArray = input.ToCharArray();

			var vCount = 0;

			foreach (var letter in CharArray)
			{
				if (CharArray.Any(item => letter.Equals('a') || letter.Equals('e') || letter.Equals('i') || letter.Equals('o') || letter.Equals('u')))
				{
					vCount++;
					continue;
				}


			}

			Console.WriteLine("Total Vowels: " + vCount);
		}
		
	}
}

