/*
 * Created by SharpDevelop.
 * User: ZP2
 * Date: 02.04.2015
 * Time: 8:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of times.
	/// </summary>
	public class times: BasePrimitive
	{
		public times()
		{
		}
		
/*CREATE TABLE times (name TEXT)*/

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
		
/*CREATE TABLE times (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)*/
	}
}
