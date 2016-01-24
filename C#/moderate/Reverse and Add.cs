using System;
using System.Collections;
using System.IO;
using System.Text;

    class Program
    {
        static void Main(string[] args)
		{

			string[] lines = File.ReadAllLines(args[0]);
			//string[] lines = new string[] { "196" };
			for (int i = 0; i <=lines.Length-1; i++)
			{
				int n = 1;

				string line = (Convert.ToInt32(lines[i])).ToString();

				string re = Addstrings(line, Reverse(line));
				while (!CheckPalindrome(re) && n<=1000)
				{
					re = Addstrings(re, Reverse(re));
					n++;
				}
				if (n > 1000)
				{
					continue;
				}
			    Console.WriteLine(n+" "+re);
				//Console.ReadLine();
			}

		}
		private static bool CheckPalindrome(string n)
		{
			if (n == Reverse(n))
				return true;
			return false;
		}
		private static string Addstrings(string a, string b)
		{
			char[] aarray = a.ToCharArray();
			char[] barray = b.ToCharArray();
			ArrayList result = new ArrayList();
			int Carryover = 0;

			for (int i = aarray.Length - 1; i >= 0; i--)
			{
				int add = 0;
				add = Convert.ToInt32(aarray[i].ToString()) + Convert.ToInt32(barray[i].ToString()) + Carryover;

				if (i != 0)
				{
					Carryover = add / 10;
					add = add % 10;

				}
				result.Add(add.ToString());
				//result[i] = Convert.ToString(add);

			}
			StringBuilder sb = new StringBuilder();
			for (int  i = result.Count-1; i >=0; i--)
			{
				sb.Append(result[i].ToString());


			}
			return Convert.ToString(sb);
		}
		private static string Reverse(string s)
		{
			//string s = input.ToString();
			char[] sarray = s.ToCharArray();
			StringBuilder rev = new StringBuilder();
			for (int i = sarray.Length - 1; i >= 0; i--)
			{
				rev.Append(sarray[i]);
			}
			return Convert.ToString(rev);
		}
	}
