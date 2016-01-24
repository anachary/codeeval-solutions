//Sample code to read in test cases:
using System;
using System.IO;

class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines(args[0]);
            foreach (string line in lines)
            {
                string[] data = line.Split(' ');
                if (data.Length > 0)
                {
                    int indextogetfromlast = Convert.ToInt32(data[data.Length - 1]);// length=5;lastelementatindex=4; indextogetfromlast=4
                    int actualindextoget = data.Length - 1 - indextogetfromlast;
                    if (actualindextoget >= 0)
                    {
                        Console.WriteLine(data[actualindextoget].ToString());
                    }


                }

            }

         }
    }
