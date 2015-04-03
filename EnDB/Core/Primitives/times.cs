/*
 * Created by SharpDevelop.
 * User: ZP2
 * Date: 02.04.2015
 * Time: 8:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace EnDB.Core.Primitives
{
	/// <summary>
	/// Description of times.
	/// </summary>
	public class times: BasePrimitive
	{
		public times()
		{
		}
		
		private String mName = null;
		
		public String Name
		{
			get{
				return this.mName;
			}
			
			set{
				if(this.mName == value)
				{
					return;
				}
				
				this.mName = value;
				
				this.EmitModified();
			}
		}
		
		public override string ToString()
		{
			StringBuilder tmpSb = new StringBuilder();
			
			tmpSb.AppendLine("Begin times ");
			
			tmpSb.Append(base.ToString());
			
			tmpSb.Append("Name = ");
			tmpSb.AppendLine(this.Name);
			
			tmpSb.AppendLine("End Times");
			
			return tmpSb.ToString();
		}

		
		protected override bool LoadHandler()
		{
			StringBuilder tmpSb = new StringBuilder();
			
			throw new NotImplementedException();
		}
		
		protected override bool SaveHandler()
		{			
			throw new NotImplementedException();
		}
		
		protected override bool IsContainsInDBHandler()
		{
			using(DBCommon.DBConnection db = new DBCommon.DBConnection(this.ConnectionString))
			{
				StringBuilder tmpSb = new StringBuilder();
				
				tmpSb.Append("SELECT COUNT(*) AS 'COUNT' FROM times WHERE id = ");
				tmpSb.Append(this.Id);
				
				NLog.LogManager.GetCurrentClassLogger().Info(tmpSb.ToString());
								
				System.Data.SQLite.SQLiteDataReader tmpReader = db.ExecuteQuery(tmpSb.ToString());
				
				if(tmpReader.Read())
				{
					return (tmpReader.GetInt32(0) > 0);
				}
				
				return false;
			}
		}
		
		protected override bool InsertHandler()
		{
			using(DBCommon.DBConnection db = new DBCommon.DBConnection(this.ConnectionString))
			{
				NLog.LogManager.GetCurrentClassLogger().Info("InsertHandler");
				
				StringBuilder tmpSb = new StringBuilder();
				
				return true;
			}
		}
		
		protected override bool UpdateHandler()
		{
			using(DBCommon.DBConnection db = new DBCommon.DBConnection(this.ConnectionString))
			{
				NLog.LogManager.GetCurrentClassLogger().Info("UpdateHandler");
				
				StringBuilder tmpSb = new StringBuilder();
				
				return true;
			}
		}
		
		protected override bool RemoveHandler()
		{
			StringBuilder tmpSb = new StringBuilder();
			
			throw new NotImplementedException();
		}
		
/*CREATE TABLE times (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)*/
	}
}
