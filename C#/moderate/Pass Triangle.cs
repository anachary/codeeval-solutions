using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    public static List<List<Int64>> Alllinesnumber = new List<List<Int64>>();
    static void Main(string[] args)
	{

			string[] lines = File.ReadAllLines(args[0]);

			foreach (string line in lines)
			{
				List<Int64> numberlist= new List<Int64>();
				line.TrimEnd(' ');
				string[] numbers = line.Split(' ');
				for (int i = 0; i < numbers.Length ; i++)
				{
					if (!string.IsNullOrEmpty(numbers[i]))
					{
						numberlist.Add(Convert.ToInt64(numbers[i]));
					}
				}

			 Alllinesnumber.Add(numberlist);
			}

			Int64 value=GetMaxValue(Alllinesnumber.Count);
			Console.WriteLine(value.ToString());


	}
	static Int64 GetMaxValue(int len)
	{


		for (int i = len-2; i >= 0; i--)
		{
			for (int j = 0; j<=i; j++)
			{
				List<Int64> list = (List<Int64>)Alllinesnumber[i + 1];
				if ((Int64)list[j] > (Int64)list[j+1])
				{
					(((List<Int64>)Alllinesnumber[i]))[j] = (Int64)list[j] + (Int64)(((List<Int64>)(Alllinesnumber[i]))[j]);

				}
				else
				{

					(((List<Int64>)Alllinesnumber[i]))[j] = (Int64)list[j+1 ] + (Int64)(((List<Int64>)(Alllinesnumber[i]))[j]);
				}
			}

		}


		return (((List<Int64>)Alllinesnumber[0]))[0];
	}


}
