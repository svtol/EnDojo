/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 01.04.2015
 * Time: 20:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of adverb.
	/// </summary>
	public class adverb: BasePrimitive
	{
		public adverb()
		{
		}
		
/*CREATE TABLE adverb (word_value_id INTEGER, back_id_adjective INTEGER DEFAULT (0), back_id_noun INTEGER DEFAULT (0), back_id_numeral INTEGER DEFAULT (0), back_id_verb INTEGER DEFAULT (0))*/

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
		
/*CREATE TABLE adverb (id INTEGER PRIMARY KEY AUTOINCREMENT, word_value_id INTEGER, back_id_adjective INTEGER DEFAULT (0), back_id_noun INTEGER DEFAULT (0), back_id_numeral INTEGER DEFAULT (0), back_id_verb INTEGER DEFAULT (0))*/
	}
}
