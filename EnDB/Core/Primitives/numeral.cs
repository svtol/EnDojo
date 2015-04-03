/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 01.04.2015
 * Time: 20:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of numeral.
	/// </summary>
	public class numeral: BasePrimitive
	{
		public numeral()
		{
		}
		
/*CREATE TABLE numeral (word_value_id INTEGER, back_id_adjective INTEGER DEFAULT (0), back_id_adverb INTEGER DEFAULT (0), back_id_noun INTEGER DEFAULT (0), back_id_verb INTEGER DEFAULT (0), kind INTEGER DEFAULT (0), cardinal_id INTEGER DEFAULT (0), ordinal_id INTEGER DEFAULT (0))*/

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
		
/*CREATE TABLE numeral (id INTEGER PRIMARY KEY AUTOINCREMENT, word_value_id INTEGER, back_id_adjective INTEGER DEFAULT (0), back_id_adverb INTEGER DEFAULT (0), back_id_noun INTEGER DEFAULT (0), back_id_verb INTEGER DEFAULT (0), kind INTEGER DEFAULT (0), cardinal_id INTEGER DEFAULT (0), ordinal_id INTEGER DEFAULT (0))*/
	}
}
