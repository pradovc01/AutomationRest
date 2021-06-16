using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApplication.Automation.KorberRest.Dto
{
	public class DataBaseRegistrationDto
	{
		public Guid Id { get; set; }
		public string ApplicationId { get; set; }
		public string Description { get; set; }
		public string DataSource { get; set; }
		public string Database { get; set; }
		public string UserName { get; set; }
		public string UserPassword { get; set; }
	}
}
