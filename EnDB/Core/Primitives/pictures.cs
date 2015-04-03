/*
 * Created by SharpDevelop.
 * User: ZP2
 * Date: 02.04.2015
 * Time: 8:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of pictures.
	/// </summary>
	public class pictures: BasePrimitive
	{
		public pictures()
		{
		}
		
/*CREATE TABLE pictures (name TEXT)*/

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
		
/*CREATE TABLE pictures (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)*/
	}
}
