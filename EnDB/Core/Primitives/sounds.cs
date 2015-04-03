/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 01.04.2015
 * Time: 20:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of sounds.
	/// </summary>
	public class sounds: BasePrimitive
	{
		public sounds()
		{
		}
		
/*
	CREATE TABLE sounds (name TEXT)    
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
	CREATE TABLE sounds (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)    
*/ 
	}
}
