/*
 * Created by SharpDevelop.
 * User: svtol
 * Date: 29.03.2015
 * Time: 20:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;

namespace TST
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here

            string connectionString = @"Data Source=c:\Users\svtol\Google Диск\ENDojo\En.db";
			
            using(DBCommon.DBConnection db = new DBCommon.DBConnection(connectionString))
            {
            	string queryString = "SELECT COUNT(*) AS 'C' FROM F";
            	
            	System.Data.SQLite.SQLiteDataReader tmpReader = db.ExecuteQuery(queryString);
            	
                if (tmpReader.Read())
                {
                    Console.WriteLine("tmpReader.Read()");

                    Console.WriteLine(tmpReader.GetInt32(0));
                }
                else
                {
                    Console.WriteLine("tmpReader.Read()");
                }            	
            }
            
			/*using(System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection(connectionString))
			{
				string queryString = "SELECT COUNT(*) AS 'C' FROM F";
				
				System.Data.SQLite.SQLiteCommand command = new System.Data.SQLite.SQLiteCommand(queryString, connection);
				
				connection.Open();

                var tmpReader = command.ExecuteReader();

                if (tmpReader.Read())
                {
                    Console.WriteLine("tmpReader.Read()");

                    Console.WriteLine(tmpReader.GetInt32(0));
                }
                else
                {
                    Console.WriteLine("tmpReader.Read()");
                }
			}*/
			
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadLine();
		}
	}
}