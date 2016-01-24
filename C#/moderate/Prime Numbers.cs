using System;
using System.IO;
using System.Collections;
namespace vertical_prime
{
    class Program
	{


    	static void Main(string[] args)
		{

		//args = new string[] { "C:\\Users\\Akash\\Desktop\\Personal Stuff\\codeeval\\vertical prime\\verticalprime.txt" };
		string[] lines=File.ReadAllLines(args[0]);

		foreach (string line in lines)
		{

			Int64  d = Convert.ToInt64(line);
			int coma = 0;
			for(Int64  i=0;i<d;i++)
			{

				if (isPrime(i))
				{
					if (coma == 0)
					{
						coma = 1;
						Console.Write(i.ToString());
					}
					else
					{
						Console.Write("," + i.ToString());
					}

				}


			}
			Console.WriteLine();
		}

	   }



		public static bool isPrime(Int64 number)
		{

			if (number == 0 || number == 1)
				return false;

			for (Int64 l = 1; l < number; l++)
			{
				if (number % l == 0)
				 {
					 if (l == 1)
					 { continue; }
					 return false;

				 }
			}
			return true;
		}
	}
}
