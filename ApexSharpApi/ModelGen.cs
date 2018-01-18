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
        public IEnumerable<string> GetAllObjectNames()
        {
            var objectList = new List<string>();

            var httpManager = new HttpManager();
            var requestJson = httpManager.Get("sobjects/");

            var cacheLocation = Path.Combine(ApexSharp.GetSession().VsProjectLocation, "Cache", "objectList.json");
            File.WriteAllText(cacheLocation, requestJson);
            var json = File.ReadAllText(cacheLocation);

            var sObjectList = JsonConvert.DeserializeObject<SObjectDescribe>(json);
            foreach (var sobject in sObjectList.sobjects)
            {
                objectList.Add(sobject.name);
            }

            return objectList;
        }

        public void CreateOfflineSymbolTable(List<string> sobjectList, string nameSpace)
        {
            Parallel.ForEach(sobjectList, sobject =>
            {
                var httpManager = new HttpManager();
                var objectDetailjson = httpManager.Get($"sobjects/{sobject}/describe");

                var sObjectDetail = JsonConvert.DeserializeObject<SObjectDetail>(objectDetailjson);

                objectDetailjson = JsonConvert.SerializeObject(sObjectDetail, Formatting.Indented);
                var jsonFileName =  sobject + ".json";
                var cacheLocation = Path.Combine(ApexSharp.GetSession().VsProjectLocation, "Cache", jsonFileName);

                File.WriteAllText(cacheLocation, objectDetailjson);

                var sObjectClass = CreateSalesForceClass(nameSpace, sObjectDetail);
                var saveFileName = sobject + ".cs";
                var sobjectLocation = Path.Combine(ApexSharp.GetSession().VsProjectLocation, "SObjects", saveFileName);

                File.WriteAllText(sobjectLocation, sObjectClass);

                Log.ForContext<ModelGen>().Debug("Saved {sobject}", saveFileName);
            });
        }

        internal string CreateSalesForceClass(string nameSpace, SObjectDetail objectDetail)
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
                    sb.AppendLine($"\t\tpublic {GetFieldType(objectField)} {objectField.name} {setGet}");
                }
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();
        }

        public List<Sobject> GetAllObjects()
        {
            string objectListPath = Path.Combine(ApexSharp.GetSession().VsProjectLocation, "objectList.json");

            HttpManager httpManager = new HttpManager();
            var requestJson = httpManager.Get("sobjects/");
            File.WriteAllText(objectListPath, requestJson);

            var json = File.ReadAllText(objectListPath);
            SObjectDescribe sObjectList = JsonConvert.DeserializeObject<SObjectDescribe>(json);
            return sObjectList.sobjects.ToList();
        }

        internal string GetFieldType(Field salesForceField)
        {
            var valueFound = FieldDictionary.TryGetValue(salesForceField.type, out var value);
            if (valueFound)
            {
                return value;
            }
            Log.Logger.Error($"Field Type: {salesForceField.type} Field Name : {salesForceField.name} Field Length: {salesForceField.length}");
            return "NOT FOUND";
        }

        private static readonly Dictionary<string, string> FieldDictionary = new Dictionary<string, string>
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
            {"complexvalue", "string" }
        };
    }
}