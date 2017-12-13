using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ApexSharpApi.Model.RestApi;
using Newtonsoft.Json;
using Serilog;

namespace ApexSharpApi
{
    public class ModelGen
    {
        public List<string> GetAllObjectNames()
        {
            List<string> objectList = new List<string>();

            HttpManager httpManager = new HttpManager();
            var requestJson = httpManager.Get($"sobjects/");

            var cacheLocation = Path.Combine(ConnectionUtil.GetSession().VsProjectLocation, "Cache");
            File.WriteAllText(cacheLocation + "/objectList.json", requestJson);
            var json = File.ReadAllText(cacheLocation + "/objectList.json");

            SObjectDescribe sObjectList = JsonConvert.DeserializeObject<SObjectDescribe>(json);
            foreach (var sobject in sObjectList.sobjects)
            {
                objectList.Add(sobject.name);
            }

            return objectList;
        }

        public void CreateOfflineSymbolTable(List<string> sobjectList)
        {
            var nameSpace = ConnectionUtil.GetSession().VsProjectName + ".SObjects";

            Parallel.ForEach(sobjectList, (sobject) =>
            {
                HttpManager httpManager = new HttpManager();
                var objectDetailjson = httpManager.Get($"sobjects/{sobject}/describe");

                SObjectDetail sObjectDetail = JsonConvert.DeserializeObject<SObjectDetail>(objectDetailjson);

                objectDetailjson = JsonConvert.SerializeObject(sObjectDetail, Formatting.Indented);
                var cacheLocation = Path.Combine(ConnectionUtil.GetSession().VsProjectLocation, "Cache");
                var jsonFileName = cacheLocation + "/" + sobject + ".json";
                File.WriteAllText(jsonFileName, objectDetailjson);

                var sObjectClass = CreateSalesForceClasses(nameSpace, sObjectDetail);

                var sobjectLocation = Path.Combine(ConnectionUtil.GetSession().VsProjectLocation, "SObjects");
                var saveFileName = sobjectLocation + "\\" + sobject + ".cs";
                File.WriteAllText(saveFileName, sObjectClass);

                Log.ForContext<ModelGen>().Debug("Saved {sobject}", saveFileName);
            });
        }

        private string CreateSalesForceClasses(string nameSpace, SObjectDetail objectDetail)
        {
            var sb = new StringBuilder();

            sb.AppendLine("namespace " + nameSpace);
            sb.AppendLine("{");
            sb.AppendLine("\tusing Apex.System;");
            sb.AppendLine("\tusing ApexSharpApi.ApexApi;");
            sb.AppendLine();
            sb.AppendLine($"\tpublic class {objectDetail.name} : SObject");
            sb.AppendLine("\t{");

            var setGet = "{set;get;}";
            foreach (var objectField in objectDetail.fields)
            {
                if ((objectField.type == "reference") && (objectField.name == "OwnerId") && (objectField.referenceTo.Length > 1))
                {
                    sb.AppendLine($"\t\tpublic string {objectField.name} {setGet}");

                    sb.AppendLine($"\t\tpublic {objectField.referenceTo[1]} {objectField.relationshipName} {setGet}");
                }
                else if (objectField.type == "reference" && objectField.referenceTo.Length > 0)
                {
                    sb.AppendLine($"\t\tpublic string {objectField.name} {setGet}");

                    if (objectField.relationshipName != null)
                    {
                        sb.AppendLine($"\t\tpublic {objectField.referenceTo[0]} {objectField.relationshipName} {setGet}");
                    }
                }
                else if (objectField.type != "id")
                {
                    sb.AppendLine($"\t\tpublic {GetField(objectField)} {objectField.name} {setGet}");
                }
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();

        }

        public List<Sobject> GetAllObjects()
        {
            string dirPath = ConnectionUtil.GetSession().VsProjectLocation;

            HttpManager httpManager = new HttpManager();
            var requestJson = httpManager.Get($"sobjects/");
            File.WriteAllText(dirPath + @"\objectList.json", requestJson);

            var json = File.ReadAllText(dirPath + @"\objectList.json");
            SObjectDescribe sObjectList = JsonConvert.DeserializeObject<SObjectDescribe>(json);
            return sObjectList.sobjects.ToList();

            //var customObjectCount = allSobjects.Where(x => x.custom).ToList();
            //var customSetting = allSobjects.Where(x => x.customSetting).ToList();
            //var objectCount = allSobjects.Where(x => x.custom == false && x.customSetting == false).ToList();

            //System.Console.WriteLine(customObjectCount.Count());
            //System.Console.WriteLine(customSetting.Count());
            //System.Console.WriteLine(objectCount.Count());
        }

        private string GetField(Field salesForceField)
        {
            var valueFound = FieldDictionary.TryGetValue(salesForceField.type, out var value);
            if (valueFound)
            {
                return value;
            }
            Log.Logger.Error($"Field Type: {salesForceField.type} Field Name : {salesForceField.name} Field Length: {salesForceField.length}");
            return "NOT FOUND";
        }

        public static Dictionary<string, string> FieldDictionary = new Dictionary<string, string>()
        {
            {"address", "Address" },
            {"id","ID" },
            {"string","string" },
            {"picklist","string" },
            {"email","string" },
            {"textarea","string" },
            {"phone","string" },
            {"url","string" },
            {"reference","string" },
            {"combobox","string" },
            {"multipicklist","string" },
            {"anytype","object" },
            {"location","string" },
            {"boolean","bool" },
            {"datetime","DateTime" },
            {"time","DateTime" },
            {"date","DateTime" },
            {"currency","double" },
            {"percent","double" },
            {"double","double" },
            {"int","int" },
            {"anyType", "object" },
            {"base64", "string" },
            {"complexvalue", "string" },
        };
    }
}