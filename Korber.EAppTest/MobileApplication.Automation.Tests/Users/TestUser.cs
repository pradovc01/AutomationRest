using Korber.EAppTest.MT.MobileApplication.Automation.Tests.Utitlities.EnvironmentVariables;

namespace Korber.EAppTest.MT.MobileApplication.Automation.Tests.Users
{
	public class TestUser : HighJump.Platform.Integration.Tests.Base.UserCredentials
	{
		public override string UserName
		{
			get { return ConfigurationVariable.UserName ; }
		}

		public override string UserPassword
		{
			get { return ConfigurationVariable.UserPassword; }
		}
	}
}

// This file generated by Accellos MT Generator.
// NVelocity Template used: Accellos.MtGenerator.VelocityTemplates.v3._1._3._0.MobileApplication.Automation.TestUser.vm
