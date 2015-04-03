/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 01.04.2015
 * Time: 20:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of comparsions.
	/// </summary>
	public class comparsions: BasePrimitive
	{
		public comparsions()
		{
		}
		
/*
CREATE TABLE comparsions (name TEXT)
*/

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
		
/*
CREATE TABLE comparsions (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)
*/
	}
}
