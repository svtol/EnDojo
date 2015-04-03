/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 30.03.2015
 * Time: 18:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using System.Linq;

namespace DBCommon
{
	/// <summary>
	/// Description of DBConnection.
	/// </summary>
	public class DBConnection: IDisposable
	{
		static DBConnection()
		{
			
		}
		
		private static String mDefaultConnectionString = null;
		
		public static String DefaultConnectionString
		{
			get{
				return mDefaultConnectionString;
			}
			
			set{
				mDefaultConnectionString = value;
			}
		}
	
		public DBConnection()
			:this((String)null)
		{
			
		}
		
		public DBConnection(String connectionString)
		{
			if(string.IsNullOrWhiteSpace(connectionString))
			{
				this.ConnectionString = DefaultConnectionString;
			}else{
				this.ConnectionString = connectionString;
			}
		}
				
		private String mConnectionString = null;
		
		private SQLiteConnection mConnection = null;
		
		public String ConnectionString
		{
			get{
				return this.mConnectionString;
			}
			
			private set{
				this.mConnectionString = value;
				
				this.mConnection = new SQLiteConnection(this.ConnectionString);
			}
		}
		
		public SQLiteDataReader ExecuteQuery(String query, SQLiteParameterCollection paramsCollection = null)
		{
			this.mConnection.Open();
			
			SQLiteCommand tmpCommand = this.CreateCommand(query, paramsCollection);
			
			SQLiteDataReader tmpReader = tmpCommand.ExecuteReader();
			
			return tmpReader;
		}
		
		public int ExecuteNonQuery(String query, SQLiteParameterCollection paramsCollection = null)
		{
			this.mConnection.Open();
			
			SQLiteCommand tmpCommand = this.CreateCommand(query, paramsCollection);
			
			return tmpCommand.ExecuteNonQuery();
		}
		
		public Object ExecuteScalar(String query, SQLiteParameterCollection paramsCollection = null)
		{
			this.mConnection.Open();
			
			SQLiteCommand tmpCommand = this.CreateCommand(query, paramsCollection);
			
			return tmpCommand.ExecuteScalar();
		}
		
		private SQLiteCommand CreateCommand(String query, SQLiteParameterCollection paramsCollection)
		{
			SQLiteCommand tmpCommand = this.mConnection.CreateCommand();
			
			tmpCommand.CommandText = query;
			
			if(paramsCollection != null && paramsCollection.Count > 0)
			{
				foreach(SQLiteParameter param in paramsCollection)
				{
					tmpCommand.Parameters.Add(param);
				}
			}
			
			return tmpCommand;
		}
		
		public void Close()
		{
			this.mConnection.Close();
		}
		
		public void Dispose()
		{			
			this.Close();
		}
	}
}
