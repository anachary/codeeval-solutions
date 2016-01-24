//Sample code to read in test cases:
using System.IO;
using System.Collections.Generic;
using System;

class Program
{
        static void Main(string[] args)
		{
			string[] lines = File.ReadAllLines(args[0]);
			foreach(string line in lines)
			{
				string[] numbers=line.Split(';');
			      foreach(string number in numbers)
				  {
					  Console.Write((Getnumber(number)).ToString());

				  }
				  Console.WriteLine();
			}

		}
		public static int Getnumber(string number)
		{
			int result = 0;
			switch (number)
			{
				case "zero": result = 0;
					break;
				case "one": result = 1;
					break;
				case "two": result = 2;
					break;
				case "three": result = 3;
					break;
				case "four": result = 4;
					break;
				case "five": result = 5;
					break;
				case "six": result = 6;
					break;
				case "seven": result = 7;
					break;
				case "eight": result = 8;
					break;
				case "nine": result = 9;
					break;
				default: result = 0;
					break;

			}
			return result;
		 }


}
