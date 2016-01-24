using System;
using System.Collections.Generic;
using System.IO;

namespace LongestLines
{
    class Program
	{
		static void Main(string[] args)
		{

			string[] lines = File.ReadAllLines(args[0]);
			int N = Convert.ToInt32(lines[0]);
			Dictionary<int, List<string>> lengthline = new Dictionary<int,List<string>>();
			List<int> lengths = new List<int>();
			for (int i = 1; i <= lines.Length - 1; i++)
			{
				int len = lines[i].Length;
				if (lengthline.ContainsKey(len))
				{
					((List<string>)(lengthline[len])).Add(lines[i]);

				}
				else
				{
					List<string> linelist = new List<string>();
					linelist.Add(lines[i]);
					lengthline.Add(len, linelist);

				}
				bool lenexists = false;
				foreach(int k in lengths)
				{
					if (k == len)
					{
						lenexists = true;
						break;
					}
				}
				if (!lenexists)
				{ lengths.Add(len); }

			}
			lengths.Sort();
			for (int i = 0; i <= N - 1; i++)
			{
				int key=lengths[lengths.Count - 1];
				foreach (string s in lengthline[key])
				{
					Console.WriteLine(s);
				}
				lengths.RemoveAt(lengths.Count - 1);
			}

		}
	}
}
