/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 01.04.2015
 * Time: 20:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of word.
	/// </summary>
	public class word: BasePrimitive
	{
		public word()
		{
		}
		
/*
CREATE TABLE word (text TEXT, transcription TEXT, sound_id INTEGER, is_root BOOLEAN)
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
CREATE TABLE word (id INTEGER PRIMARY KEY AUTOINCREMENT, text TEXT, transcription TEXT, sound_id INTEGER, is_root BOOLEAN)
*/ 
	}
}
