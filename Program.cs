using System;

namespace SpecialNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int inputNum = int.Parse(Console.ReadLine());

			for (int i = 1; i <= inputNum; i++)
			{
				int sumOfDigits = 0;
				int digits = i;
				while (digits > 0)
				{
					sumOfDigits += digits % 10;
					digits = digits / 10;
				}
				bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
				Console.WriteLine("{0} -> {1}", i, special);
			}
		}
	}
}
