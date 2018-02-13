using System;
using System.Collections.Generic;
using System.Linq;

namespace ApexSharpApi
{
    public class ObjectInfo
    {
        public string ObjectName { get; set; }
        public List<string> FieldNames = new List<string>();
    }
    public class SoqlAst
    {
        public string ObjectName { get; set; }
        public List<string> FieldNames = new List<string>();
    }
    public class SoqlParser
    {
        public static void Test()
        {
            var ast = ParseSoql("SOQL Code");
            //Console.WriteLine(ValidateSoql(ast));
            GetMissingFields(ast);
        }

        public static SoqlAst ParseSoql(string soql)
        {
            var ast = new SoqlAst { ObjectName = "Contact" };
            ast.FieldNames.Add("Id");
            ast.FieldNames.Add("Email");

            return ast;
        }

        public static List<string> GetMissingFields(SoqlAst soqlAst)
        {
            var missingFields = GetObjectInfo(soqlAst.ObjectName).FieldNames.Except(soqlAst.FieldNames).ToList();
            Console.WriteLine(String.Join(", ", missingFields.ToArray()));
            return missingFields;
        }

        public static bool ValidateSoql(SoqlAst soqlAst)
        {
            var objectInfo = GetObjectInfo(soqlAst.ObjectName);

            if (objectInfo == null)
            {
                Console.WriteLine("Bad Object Name " + soqlAst.ObjectName);
                return false;
            }
            else
            {
                foreach (var soqlAstFieldName in soqlAst.FieldNames)
                {
                    if (objectInfo.FieldNames.Contains(soqlAstFieldName) == false)
                    {
                        Console.WriteLine("Bad " + soqlAstFieldName);
                        return false;
                    }
                }
            }
            return true;
        }



        public static ObjectInfo GetObjectInfo(string objectName)
        {
            if (objectName == "Contact")
            {
                var objectInfo = new ObjectInfo { ObjectName = "Contact" };
                objectInfo.FieldNames.Add("Id");
                objectInfo.FieldNames.Add("Email");
                objectInfo.FieldNames.Add("Name");
                return objectInfo;
            }
            else
            {
                return null;
            }


        }
    }
}
