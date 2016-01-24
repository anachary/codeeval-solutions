using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridWalk
{

    public class GridWalk
	{
       public static List<location> validlocations = new List<location>();// stores all the valid locations  final count of this is right answer.
	  public static Dictionary<location,bool> visited =new Dictionary<location,bool>();//visted has location and bool value stating if the monkey traved the co-ordinated before.

		public bool isvalidlocation(location loc)
		{
			return (totalsum(loc.X)+totalsum(loc.Y))<=19;

		}
		public int totalsum(int num)
		{
			int result =0;
			Char[] number = (Convert.ToString(Math.Abs(num))).ToArray();
			for (int i = 0; i <=number.Length - 1; i++)
			{
				result += Convert.ToInt32(number[i].ToString());
			}
			return result;
		}

		public void visit(location loc)
		{
			if (visited.ContainsKey(loc))
			{
				visited[loc] = true;
			}
			else
			{
				visited.Add(loc, true);
			}
			CheckAndAddAdjacentLocation(loc);

		}
		//
		public void CheckAndAddAdjacentLocation(location loc)
		{
			location  right  = new location(loc.X + 1, loc.Y);
			location left = new location(loc.X - 1, loc.Y);
			location up = new location(loc.X, loc.Y + 1);
			location down = new location(loc.X, loc.Y - 1);

			Addlocationifvalid(right);
			Addlocationifvalid(left);
			Addlocationifvalid(up);
			Addlocationifvalid(down);

		}
		public void Addlocationifvalid(location loc)
		{
			if (!visited.ContainsKey(loc) && isvalidlocation(loc))
			{

				validlocations.Add(loc);
				visited.Add(loc, false);
			}
		}
		static void Main(string[] args)
		{
			GridWalk monkeywalk = new GridWalk();
			location orgin = new location(0, 0);
			GridWalk.validlocations.Add(orgin);
			int index = 0;
			while (true)
			{
				if (index >= validlocations.Count)
					break;
				monkeywalk.visit(GridWalk.validlocations[index]);
				index++;
			}

			Console.WriteLine(GridWalk.validlocations.Count);
			//Console.ReadLine();
		}
	}
	public class location
	{
		int x_coordinate;
		int y_coordinate;

		public location(int x, int y)
		{
			x_coordinate = x;
			y_coordinate = y;
		}
		public int X
		{
			get { return x_coordinate; }
			set { x_coordinate = value; }
		}
		public int Y
		{
			get { return y_coordinate; }
			set { y_coordinate = value; }
		}
		public override bool Equals(object obj)
		{

		      location args= (location)obj ;

				  return ((args.X == this.X) && (args.Y == this.Y));

		}
		public override int GetHashCode()
		{
			return X.GetHashCode()^Y.GetHashCode();
		}
	}
}
