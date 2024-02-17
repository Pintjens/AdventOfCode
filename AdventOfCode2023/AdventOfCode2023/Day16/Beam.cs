using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
	internal enum Direction
	{
		Up, Right, Down , Left
	}
	internal class Beam
	{
		public static List<Beam> AllBeams = new List<Beam>();
		public int[] Possition { get; set; }
		public Direction LightDirection { get; set; }

		public Beam(int[] possition, Direction direction)
		{
			this.Possition = possition;
			this.LightDirection = direction;
		}

	}
}
