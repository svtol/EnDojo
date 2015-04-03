/*
 * Created by SharpDevelop.
 * User: ZP2
 * Date: 02.04.2015
 * Time: 8:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of translate.
	/// </summary>
	public class translate: BasePrimitive
	{
		public translate()
		{
		}
		
/*CREATE TABLE translate (value TEXT)*/

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
		
/*CREATE TABLE translate (id INTEGER PRIMARY KEY AUTOINCREMENT, value TEXT)*/
	}
}
