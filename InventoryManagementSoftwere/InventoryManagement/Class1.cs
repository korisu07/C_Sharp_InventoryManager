using System;
using System.Data;
using System.Data.SqlClient;
class Test1
{
	static void Main()
	{
		string sql = "SELECT id,name,romaji FROM SYAIN";
		try
		{
			using (SqlConnection conn = new SqlConnection())
			{
				conn.ConnectionString =
				@"Data Source=localhost\SQLEXPRESS;" +
				"Initial Catalog=testDB1;" +
				 "Integrated Security=SSPI;";

				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql))
				{
					cmd.Connection = conn;
					cmd.CommandType = CommandType.Text;
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Console.WriteLine(reader["id"] + ":"
											+ reader["name"] + ":"
											+ reader["romaji"]);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message.ToString());
		}
	}
}