using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Application.Automation.KorberData
{
	public abstract class SqlAbstract
	{
		protected string ConnectionString;
		protected string SqlSelectString = "SELECT <SELECT> " +
																			 "FROM <TABLE> " +
																			 "WHERE <CONDICION>";
		protected string SqlUpdateString = "UPDATE <UPDATE> " +
																			 "FROM <TABLE> " +
																			 "WHERE <CONDICION>";
		protected string SqlDeleteString = "DELETE " +
																			 "FROM <TABLE> " +
																			 "WHERE <CONDICION>";

		protected void SelectQuery(string outputFields, string table, string condicion, string extraFilter = null)
		{
			SqlSelectString = SqlSelectString.Replace("<SELECT>", outputFields);
			SqlSelectString = SqlSelectString.Replace("<TABLE>", table);
			SqlSelectString = SqlSelectString.Replace("<CONDICION>", condicion);
			if (extraFilter != null)
				SqlSelectString += extraFilter;
		}

		protected void UpdateQuery(string fieldsToUpdate, string table, string condicion)
		{
			SqlUpdateString = SqlUpdateString.Replace("<UPDATE>", fieldsToUpdate);
			SqlUpdateString = SqlUpdateString.Replace("<TABLE>", table);
			SqlUpdateString = SqlUpdateString.Replace("<CONDICION>", condicion);

		}
		
		public abstract List<Dictionary<string, object>> RequestData(string outputFields, string table, string condicion, string extraFilter = null);
		public List<T> FindRow<T>(List<Dictionary<string, object>> requestData)
		{

			var jsonRequest = JsonConvert.SerializeObject(requestData);
			return JsonConvert.DeserializeObject<List<T>>(jsonRequest);
		}
		public abstract bool UpdateRow(string outputFields, string table, string condicion);
	}
}
