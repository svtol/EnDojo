/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 01.04.2015
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of parts_of_speech.
	/// </summary>
	public class parts_of_speech: BasePrimitive
	{
		public parts_of_speech()
		{
		}
		
/*CREATE TABLE parts_of_speech (name TEXT)*/

		protected override bool LoadHandler()
		{
			throw new NotImplementedException();
		}
		
		protected override bool SaveHandler()
		{
			throw new NotImplementedException();
		}
		
		protected override bool RemoveHandler()
		{
			throw new NotImplementedException();
		}
		
/*CREATE TABLE parts_of_speech (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)*/
	}
}
