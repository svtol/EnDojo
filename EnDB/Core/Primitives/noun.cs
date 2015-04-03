/*
 * Created by SharpDevelop.
 * User: ZP2
 * Date: 02.04.2015
 * Time: 8:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of noun.
	/// </summary>
	public class noun: BasePrimitive
	{
		public noun()
		{
		}
		
/*CREATE TABLE noun (word_value_id INTEGER, back_id_adjective INTEGER DEFAULT (0), back_id_adverb INTEGER DEFAULT (0), back_id_numeral INTEGER DEFAULT (0), back_id_verv INTEGER DEFAULT (0), base_sing_id INTEGER DEFAULT (0), base_pl_id INTEGER DEFAULT (0), possessive_sing_id INTEGER DEFAULT (0), possessive_pl_id INTEGER DEFAULT (0), adjective_id INTEGER DEFAULT (0), adverb_id INTEGER DEFAULT (0))*/

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
		
/*CREATE TABLE noun (id INTEGER PRIMARY KEY AUTOINCREMENT, word_value_id INTEGER, back_id_adjective INTEGER DEFAULT (0), back_id_adverb INTEGER DEFAULT (0), back_id_numeral INTEGER DEFAULT (0), back_id_verv INTEGER DEFAULT (0), base_sing_id INTEGER DEFAULT (0), base_pl_id INTEGER DEFAULT (0), possessive_sing_id INTEGER DEFAULT (0), possessive_pl_id INTEGER DEFAULT (0), adjective_id INTEGER DEFAULT (0), adverb_id INTEGER DEFAULT (0))*/
	}
}
