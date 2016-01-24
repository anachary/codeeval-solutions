using System;
using System.IO;



class Program
{

    static void Main(string[] args)
    {
        try
        {

            string[] lines = File.ReadAllLines(args[0]);
            foreach (string line in lines)
            {

                string[] data = line.Split(';');
                string length = data[0];
                string width = data[1];
                int n = Convert.ToInt32(length);
                int m = Convert.ToInt32(width);
                string[] numbers = data[2].Split(' ');
                string[,] matrix = new string[n, m];
                int numberindex = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = numbers[numberindex];
                        numberindex++;
                    }
                }




                SpiralPrinting(matrix, n, m);

                Console.WriteLine();
                //Console.ReadLine();

            }


        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Console.ReadLine();
        }
    }

    public static void SpiralPrinting(string[,] matrix, int n, int m)
    {
        bool[,] boolmatrix = new bool[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                boolmatrix[i, j] = false;
            }
        }
        if (n == 0 || m == 0)
        {
            return;

        }
        if (n <= 2 || m <= 2)
        {
            string[,] strpmat = StripBorder(matrix, boolmatrix, ref n, ref m);


        }
        else
        {

            string[,] newmatrix = StripBorder(matrix, boolmatrix, ref n, ref m);
            SpiralPrinting(newmatrix, n, m);
        }

    }
    public static string[,] StripBorder(string[,] matrix, bool[,] boolmatrix, ref int n, ref int m)
    {
        string[,] result = matrix;
        if (n > 2 && m > 2)
        {
            result = null;
            result = new string[n - 2, m - 2];
        }


        int nMaxR = n;//6
        int nMaxColumn = m;//3
        int hIteration = 0;
        int vIteration = 0;

        while (hIteration < nMaxColumn)
        {
            if (!boolmatrix[0, hIteration])
            {
                Console.Write(matrix[0, hIteration].ToString() + " ");
                boolmatrix[0, hIteration] = true;
            }
            hIteration++;
        }
        // hIteration=2
        nMaxR--;//5

        while (vIteration < nMaxR - 1)
        {
            if (!boolmatrix[vIteration + 1, m - 1])
            {
                Console.Write(matrix[vIteration + 1, m - 1].ToString() + " ");
                boolmatrix[vIteration + 1, m - 1] = true;
            }
            vIteration++;
        }
        nMaxColumn--;//2
        //vIteration=4;

        while (hIteration > 0)
        {
            if (!boolmatrix[n - 1, hIteration - 1])
            {
                Console.Write(matrix[n - 1, hIteration - 1].ToString() + " ");
                boolmatrix[n - 1, hIteration - 1] = true;
            }
            hIteration--;
        }
        nMaxR--;//4
        //hIteration=0;
        while (vIteration > 0)
        {
            if (!boolmatrix[vIteration, 0])
            {
                Console.Write(matrix[vIteration, 0].ToString() + " ");
                boolmatrix[vIteration, 0] = true;
            }
            vIteration--;
        }

        if (n > 2 && m > 2)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                for (int j = 1; j <= m - 2; j++)
                {
                    if (!boolmatrix[i, j])
                    {
                        int k = i - 1;
                        int l = j - 1;

                        result[k, l] = matrix[i, j];



                    }
                }
            }
            n = n - 2;
            m = m - 2;

        }
        return result;
    }

}
