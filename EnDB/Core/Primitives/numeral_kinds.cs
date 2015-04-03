/*
 * Created by SharpDevelop.
 * User: ZP2
 * Date: 02.04.2015
 * Time: 8:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of numeral_kinds.
	/// </summary>
	public class numeral_kinds: BasePrimitive
	{
		public numeral_kinds()
		{
		}
		
/*CREATE TABLE numeral_kinds (name TEXT)*/

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
		
/*CREATE TABLE numeral_kinds (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)*/
	}
}
