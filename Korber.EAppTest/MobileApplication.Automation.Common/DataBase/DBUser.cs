using System;

namespace MobileApplication.Automation.Common.DataBase
{
	public class DBUser
	{
		public Guid Id { get; set; }
		public string LogOnName { get; set; }
		public int IsEnabled { get; set; }
		public Guid DefaultRoleId { get; set; }
		public string PasswordHash { get; set; }
	}
}
