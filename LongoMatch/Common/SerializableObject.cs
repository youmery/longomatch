// 
//  Copyright (C) 2010 Andoni Morales Alastruey
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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LongoMatch.Common
{
	public class SerializableObject
	{
		protected void Save<T>(T obj, string filepath) {
			BinaryFormatter formatter = new  BinaryFormatter();
			Stream stream = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.None);
			formatter.Serialize(stream, obj);
			stream.Close();
		}

		protected static T Load<T>(string filepath) {
			BinaryFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
			var obj = formatter.Deserialize(stream);
			stream.Close();
			return (T)obj;
		}
	}
}

