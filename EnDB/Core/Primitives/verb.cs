/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 01.04.2015
 * Time: 20:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of verb.
	/// </summary>
	public class verb: BasePrimitive
	{
		public verb()
		{
		}
		
/*CREATE TABLE verb (word_value_id INTEGER, back_id_adjective INTEGER DEFAULT (0), back_id_adverb INTEGER DEFAULT (0), back_id_noun INTEGER DEFAULT (0), back_id_numeral INTEGER DEFAULT (0), is_regular BOOLEAN, time INTEGER DEFAULT (0), gr_number INTEGER DEFAULT (0), person INTEGER DEFAULT (0), present_sing_0_id INTEGER DEFAULT (0), present_sing_1_id INTEGER DEFAULT (0), present_sing_2_id INTEGER DEFAULT (0), present_sing_3_id INTEGER DEFAULT (0), present_pl_0_id INTEGER DEFAULT (0), present_pl_1_id INTEGER DEFAULT (0), present_pl_2_id INTEGER DEFAULT (0), present_pl_3_id INTEGER DEFAULT (0), present_base_id INTEGER DEFAULT (0), past_sing_0_id INTEGER DEFAULT (0), past_sing_1_id INTEGER DEFAULT (0), past_sing_2_id INTEGER DEFAULT (0), past_sing_3_id INTEGER DEFAULT (0), past_pl_0_id INTEGER DEFAULT (0), past_pl_1_id INTEGER DEFAULT (0), past_pl_2_id INTEGER DEFAULT (0), past_pl_3_id INTEGER DEFAULT (0), past_base_id INTEGER DEFAULT (0), particle_kind INTEGER DEFAULT (0), particle_base_id INTEGER DEFAULT (0), particle_1_id INTEGER DEFAULT (0), particle_2_id INTEGER DEFAULT (0))*/

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
		
/*CREATE TABLE verb (id INTEGER PRIMARY KEY AUTOINCREMENT, word_value_id INTEGER, back_id_adjective INTEGER DEFAULT (0), back_id_adverb INTEGER DEFAULT (0), back_id_noun INTEGER DEFAULT (0), back_id_numeral INTEGER DEFAULT (0), is_regular BOOLEAN, time INTEGER DEFAULT (0), gr_number INTEGER DEFAULT (0), person INTEGER DEFAULT (0), present_sing_0_id INTEGER DEFAULT (0), present_sing_1_id INTEGER DEFAULT (0), present_sing_2_id INTEGER DEFAULT (0), present_sing_3_id INTEGER DEFAULT (0), present_pl_0_id INTEGER DEFAULT (0), present_pl_1_id INTEGER DEFAULT (0), present_pl_2_id INTEGER DEFAULT (0), present_pl_3_id INTEGER DEFAULT (0), present_base_id INTEGER DEFAULT (0), past_sing_0_id INTEGER DEFAULT (0), past_sing_1_id INTEGER DEFAULT (0), past_sing_2_id INTEGER DEFAULT (0), past_sing_3_id INTEGER DEFAULT (0), past_pl_0_id INTEGER DEFAULT (0), past_pl_1_id INTEGER DEFAULT (0), past_pl_2_id INTEGER DEFAULT (0), past_pl_3_id INTEGER DEFAULT (0), past_base_id INTEGER DEFAULT (0), particle_kind INTEGER DEFAULT (0), particle_base_id INTEGER DEFAULT (0), particle_1_id INTEGER DEFAULT (0), particle_2_id INTEGER DEFAULT (0))*/
	}
}
