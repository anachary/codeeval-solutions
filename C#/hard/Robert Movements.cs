using System;
using System.Text;
using System.Collections;

namespace RobertWalk
{

    class Program
	{
		public  static ArrayList CreateGrid(int width, int height)
		{
			ArrayList list = new ArrayList();
			for (int i = 0; i < height; i++)
			{
				list.Insert( i, new ArrayList());
				for (int j = 0; j < width; j++)
				{
					((ArrayList)(list[i])).Insert(j, false);
				}
			}
			return list;
   		}
		public static int countMovements(ArrayList grid, int row, int col)
		{
			int height = grid.Count - 1;
			int width = ((ArrayList)grid[row]).Count - 1;
			int totalCount = 0;
			if((bool)((ArrayList)grid[row])[col])
			{
				return 0;

			}
			if (row == height && col == width)
			{
				return 1;

			}
			((ArrayList)grid[row])[col] = true;
			if (row < height)
			{
				totalCount += countMovements(grid, row + 1, col);
			}
			if (row > 0)
			{
				totalCount += countMovements(grid, row - 1, col);
			}

			if (col < width)
			{
				totalCount += countMovements(grid, row, col + 1);
			}

			if (col > 0)
			{
				totalCount += countMovements(grid, row, col - 1);
			}
			((ArrayList)grid[row])[col] = false;
			return totalCount;
		}
		public static void Main()
		{
			ArrayList grid = CreateGrid(4, 4);

			Console.WriteLine((countMovements(grid, 0, 0)).ToString());

		}
	}
}
