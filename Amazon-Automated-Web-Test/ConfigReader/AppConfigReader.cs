using System.Configuration;


namespace Amazon_Automated_Web_Test.ConfigReader
{

     public class AppConfigReader
     {
            public static readonly string Password = ConfigurationManager.AppSettings["password"];
     }

}

