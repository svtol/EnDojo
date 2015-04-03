/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 01.04.2015
 * Time: 20:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of tr_val_link.
	/// </summary>
	public class tr_val_link: BasePrimitive
	{
		public tr_val_link()
		{
		}
		
/*CREATE TABLE tr_val_link (translate_id INTEGER, value_id INTEGER)*/

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
		
/*CREATE TABLE tr_val_link (id INTEGER PRIMARY KEY AUTOINCREMENT, translate_id INTEGER, value_id INTEGER)*/
	}
}
