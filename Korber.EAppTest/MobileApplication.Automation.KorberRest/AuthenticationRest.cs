using System;

namespace MobileApplication.Automation.KorberRest
{
	public class AuthenticationRest
	{
		public Guid UniqueId { get; set; }
		public Guid ClientInstanceId { get; set; }
		public Guid UserId { get; set; }
		public string UserPasswordHash { get; set; }
		public Guid SessionId { get; set; }
	}
}
