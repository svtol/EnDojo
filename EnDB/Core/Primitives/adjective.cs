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
	/// Description of adjective.
	/// </summary>
	public class adjective: BasePrimitive
	{
		public adjective()
		{
		}
		
/*CREATE TABLE adjective (word_value_id INTEGER, back_id_adverb INTEGER DEFAULT (0), back_id_noun INTEGER DEFAULT (0), back_id_numeral INTEGER DEFAULT (0), back_id_verb INTEGER DEFAULT (0), comparsion INTEGER DEFAULT (0), positive_id INTEGER DEFAULT (0), comparative_id INTEGER DEFAULT (0), superlative_id INTEGER DEFAULT (0))*/

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
		
/*CREATE TABLE adjective (id INTEGER PRIMARY KEY AUTOINCREMENT, word_value_id INTEGER, back_id_adverb INTEGER DEFAULT (0), back_id_noun INTEGER DEFAULT (0), back_id_numeral INTEGER DEFAULT (0), back_id_verb INTEGER DEFAULT (0), comparsion INTEGER DEFAULT (0), positive_id INTEGER DEFAULT (0), comparative_id INTEGER DEFAULT (0), superlative_id INTEGER DEFAULT (0))*/
	}
}
