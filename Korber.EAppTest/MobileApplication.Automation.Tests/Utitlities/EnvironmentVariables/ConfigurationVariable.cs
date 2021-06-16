using System.Configuration;

namespace Korber.EAppTest.MT.MobileApplication.Automation.Tests.Utitlities.EnvironmentVariables
{
	public class ConfigurationVariable
	{
		public static string KorberPort = ConfigurationManager.AppSettings["KorberCorePort"];
    public static string KorberProtocol = ConfigurationManager.AppSettings["Protocol"];
    public static string ServerName = ConfigurationManager.AppSettings["ServerName"];
		public static string UserPasswordKorberSa = ConfigurationManager.AppSettings["UserPasswordKorberSa"];
		public static string UserName = ConfigurationManager.AppSettings["UserName"];  //korber user
    public static string UserPassword = ConfigurationManager.AppSettings["UserPassword"];  //korber user

    #region Database Settings
    public static string DatabaseServerNameKorber = ConfigurationManager.AppSettings["DatabaseServerNameKorber"];
		public static string DatabaseNameKorber = ConfigurationManager.AppSettings["DatabaseNameKorber"];
		public static string UserSqlSa = ConfigurationManager.AppSettings["UserSqlSa"];
		public static string UserPasswordSqlSa = ConfigurationManager.AppSettings["UserPasswordSqlSa"];
		#endregion

	}
}
