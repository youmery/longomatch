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
using Mono.Unix;
using System.Collections.Generic;

namespace LongoMatch.Common
{
	
	[Serializable]
	public class EncodingQuality
	{
		public string Name;
		public uint AudioQuality;
		public uint VideoQuality;
		
		public EncodingQuality ()
		{
		}
		
		public EncodingQuality (string name, uint videoQuality, uint audioQuality)
		{
			Name = name;
			VideoQuality = videoQuality;
			AudioQuality = audioQuality;
		}
		
		public override bool Equals (object obj)
		{
			EncodingQuality q;
			if (!(obj is EncodingQuality))
				return false;
			q = (EncodingQuality) obj;	
			return q.Name == Name &&
				q.AudioQuality == AudioQuality &&
				q.VideoQuality == VideoQuality;
		}
		
		public override int GetHashCode ()
		{
			return String.Format ("{0}-{1}-{2}", Name, AudioQuality, VideoQuality).GetHashCode();
		}

	}
	
	public class EncodingQualities
	{
		public static EncodingQuality Low = new EncodingQuality ("Low", 25, 50); 
		public static EncodingQuality Medium = new EncodingQuality ("Medium", 50, 50); 
		public static EncodingQuality High = new EncodingQuality ("High", 75, 75); 
		public static EncodingQuality Highest = new EncodingQuality ("Highest", 100, 75); 
		
		public static List<EncodingQuality> All {
			get {
				List<EncodingQuality> list = new List<EncodingQuality>();
				list.Add (Low);
				list.Add (Medium);
				list.Add (High);
				list.Add (Highest);
				return list;
			}
		}
	}
}

