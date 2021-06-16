using MobileApplication.Automation.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Application.Automation.KorberData
{
	public class SqlServer : SqlAbstract
	{
		private SqlConnection connection;
		public SqlServer(DBInfo databaseInfoConnection)
		{
			ConnectionString = $"User ID={databaseInfoConnection.DataBaseUser};Password={databaseInfoConnection.DataBaseUserPassword};" +
												 $"Data Source={databaseInfoConnection.DataBaseServerName}; Initial Catalog={databaseInfoConnection.DataBaseName}";
		}

		public override List<Dictionary<string, object>> RequestData(string outputFields, string table, string condicion,
				string extraFilter = null)
		{
			var resultQuery = new List<Dictionary<string, object>>();
			SelectQuery(outputFields, table, condicion, extraFilter);

			connection = new SqlConnection(ConnectionString);
			connection.Open();

			SqlCommand command = new SqlCommand(SqlSelectString, connection);
			SqlDataReader reader = command.ExecuteReader();
			object[] values = new object[reader.FieldCount];
			while (reader.Read())
			{
				Dictionary<string, object> selectValues = new Dictionary<string, object>();

				int fieldCount = reader.GetValues(values);
				for (int i = 0; i < fieldCount; i++)
				{
					selectValues.Add(reader.GetName(i),
							values[i].GetType() == typeof(Guid) ? values[i].ToString() : values[i]);
				}
				resultQuery.Add(selectValues);
			}

			//Clean up
			reader.Dispose();
			command.Dispose();
			connection.Dispose();
			connection.Close();
			return resultQuery;
		}

		public override bool UpdateRow(string outputFields, string table, string condicion)
		{
			throw new NotImplementedException();
		}
	}
}
