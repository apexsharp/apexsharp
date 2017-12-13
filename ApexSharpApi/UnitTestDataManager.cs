using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ApexSharpApi
{
    public class UnitTestDataManager
    {
        private static bool _unitTestDataManagerEnabled;



        private static string IdFileName => Path.Combine(ConnectionUtil.GetSession().VsProjectLocation, "ApexSharp.UnitTestDataManager.id.txt");

        public static void UnitTestDataManagerOn()
        {
            _unitTestDataManagerEnabled = true;
            RemoveAllIds();
        }

        public static void UnitTestDataManagerOff()
        {
            RemoveAllIds();
            _unitTestDataManagerEnabled = false;
        }

        public static void AddId(string id)
        {
            if (_unitTestDataManagerEnabled)
            {
                List<string> idList = new List<string>();

                FileInfo dataFile = new FileInfo(IdFileName);

                if (dataFile.Exists)
                {
                    idList = File.ReadAllLines(dataFile.FullName).ToList();
                }
                idList.Add(id);

                File.WriteAllLines(dataFile.FullName, idList);
            }
        }

        public static void RemoveId(string id)
        {
            if (_unitTestDataManagerEnabled)
            {
                List<string> idList = new List<string>();

                FileInfo dataFile = new FileInfo(IdFileName);
                if (dataFile.Exists)
                {
                    idList = File.ReadAllLines(dataFile.FullName).ToList();
                    idList.Remove(id);
                    File.WriteAllLines(dataFile.FullName, idList);
                }
            }
        }

        public static void RemoveAllIds()
        {
            FileInfo dataFile = new FileInfo(IdFileName);
            if (dataFile.Exists)
            {
                var idList = File.ReadAllLines(dataFile.FullName).ToList();
                idList.Clear();
                File.WriteAllLines(dataFile.FullName, idList);
            }

        }

        public static int IdCount()
        {
            List<string> idList = new List<string>();
            FileInfo dataFile = new FileInfo(IdFileName);
            if (dataFile.Exists)
            {
                idList = File.ReadAllLines(dataFile.FullName).ToList();
            }
            return idList.Count;
        }

    }
}
