using System.Collections.Generic;
using System;
using System.IO;


    class Program
    {

    	static void Main(string[] args)
		{

		//	string[] args = new string[] { "C:\\Users\\Akash\\Desktop\\Personal Stuff\\codeeval\\doublesquare.txt" };

			string[] lines = File.ReadAllLines(args[0]);
			int rows = Convert.ToInt32(lines[0]);
			//int index = 0;
			for (int i = 1; i <= rows;i++)
			{
				string line = lines[i];
			    double X = Convert.ToDouble(line);
				Dictionary<double, bool> checkDictionary = new Dictionary<double, bool>();
				List<double> sqrList = new List<double>();
		    	double j = 0;
				while ((j * j) <= X)
				{
					double sq = j * j;
					//if (!checkDictionary.ContainsKey(sq))
					checkDictionary.Add(sq, true);
					sqrList.Add(sq);
					j++;
				}

				int result = 0;
				foreach (double y in sqrList)
				{
					double Y = X - y;
					if (Y >= y)
					{
						if (checkDictionary.ContainsKey(Y))
							result++;
					}
				}

				Console.WriteLine(result.ToString());

			}

		}
	}
