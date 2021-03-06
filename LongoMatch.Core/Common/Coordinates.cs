// 
//  Copyright (C) 2013 Andoni Morales Alastruey
// 
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//  
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
// 
using System;
using System.Collections.Generic;

namespace LongoMatch.Common
{
	[Serializable]
	public class Coordinates: List<Point>
	{
		public Coordinates ()
		{
		}
		
		public override bool Equals (object obj)
		{
			Coordinates c = obj as Coordinates;
            if (c == null)
				return false;
				
			if (c.Count != Count)
				return false;
			
			for (int i=0; i<Count; i++) {
				if (c[i].X != this[i].X || c[i].Y != this[i].X)
					return false;
			}
			return true;
		}
		
		public override int GetHashCode ()
		{
			string s = "";
			
			for (int i=0; i<Count; i++) {
				s += this[i].X.ToString() +  this[i].Y.ToString();
			}
			
			return int.Parse(s);
		}
	}
	
	[Serializable]
	public class Point {
		public Point (int x, int y) {
			X = x;
			Y = y;
		}
		
		public int X {
			get;
			set;
		}
		
		public int Y {
			get;
			set;
		}
		
		public override string ToString ()
		{
			return string.Format ("[Point: X={0}, Y={1}]", X, Y);
		}
	}
}

