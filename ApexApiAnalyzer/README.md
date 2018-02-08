### Apex API analyzer

Analyzes a given Apex project to produce the list of the used APIs (classes, methods and properties).

### Syntax

>ApexApiAnalyzer.exe [ -o filename ] [ -m ] [ -n ] items...
>
>* items — the list of items to analyze. An item can be an Apex class, C# class, Zip file or Github project URL.
>* -m, --markdown — generate report in Markdown format (see below for the sample).
>* -n, --noimpl — report only API classes that have no implementation.
>* -o, --output — save the report to the the given output filename instead of STDOUT.

### Sample usage

>$ApexApiAnalyzer.exe -mo test.md https://github.com/apexsharp/apexsharp
>  
>Processing URL: https://github.com/apexsharp/apexsharp  
>Generating report: test.md

## Apex.System namespace
#### ApexPages class (not implemented)
* addMessages(Apex.System.Exception)
#### Blob class
* toString()
* valueOf(string)
#### Date class
* today()
#### Exception class
* getMessage()
#### JSON class
* deserialize(string, Apex.System.Type)
* serialize(object)
#### List class
* new List(...)
* add(...)
* clear()
* get(int)
* isEmpty()
* set(int, int)
* size()
* sort()
#### Map class
* new Map(...)
* get(...)
* keySet()
* put(...)
#### Math class
* random()
* round(double)
#### MathException class
* new MathException(string)
#### RestContext class
* request
* response
#### RestRequest class
* new RestRequest()
* requestBody
#### RestResponse class
* new RestResponse()
* statusCode
#### SelectOption class (not implemented)
* new SelectOption(string, string)
#### Set class
* new Set(...)
* add(...)
* remove(int)
#### StringExtensions class
* string.length()
#### System class
* assert(bool)
* assert(bool, object)
* assertEquals(object, object)
* assertEquals(object, object, object)
* assertNotEquals(object, object, object)
* debug(object)
* runAs(Apex.System.Version)
#### Time class
* newInstance(int, int, int, int)
