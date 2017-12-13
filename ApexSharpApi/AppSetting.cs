using System.IO;

namespace ApexSharpApi
{
    public class AppSetting
    {
        public static FileInfo GetConfigLocation()
        {
            //try
            //{
            //    var appSettings = ConfigurationManager.AppSettings;

            //    var location = appSettings["SalesForceRoot"];
            //    if (location == null)
            //    {
            //        Console.WriteLine("AppSettings Missing");
            //        return null;
            //    }

            //    var newDir = new DirectoryInfo(location);
            //    if (newDir.Exists)
            //    {
            //        FileInfo newFileInfo = new FileInfo(newDir.FullName + "config.json");
            //        return newFileInfo;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dir Does Not Exist " + newDir);
            //    }
            //}
            //catch (ConfigurationErrorsException)
            //{
            //    Console.WriteLine("Error reading app settings");
            //}

            return null;
        }
    }
}
