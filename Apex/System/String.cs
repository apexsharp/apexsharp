namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_string.htm#apex_methods_system_string
    /// </summary>
    public class String
    {
        // infrastructure
        public String(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(string));
            }
        }

        // API
        public string abbreviate(int maxWidth)
        {
            return Self.abbreviate(maxWidth);
        }

        public string abbreviate(int maxWidth, int offset)
        {
            return Self.abbreviate(maxWidth, offset);
        }

        public string capitalize()
        {
            return Self.capitalize();
        }

        public string center(int size)
        {
            return Self.center(size);
        }

        public string center(int size, string paddingString)
        {
            return Self.center(size, paddingString);
        }

        public int charAt(int index)
        {
            return Self.charAt(index);
        }

        public int codePointAt(int index)
        {
            return Self.codePointAt(index);
        }

        public int codePointBefore(int index)
        {
            return Self.codePointBefore(index);
        }

        public int codePointCount(int beginIndex, int endIndex)
        {
            return Self.codePointCount(beginIndex, endIndex);
        }

        public int compareTo(string secondString)
        {
            return Self.compareTo(secondString);
        }

        public bool contains(string substring)
        {
            return Self.contains(substring);
        }

        public bool containsAny(string inputString)
        {
            return Self.containsAny(inputString);
        }

        public bool containsIgnoreCase(string substring)
        {
            return Self.containsIgnoreCase(substring);
        }

        public bool containsNone(string inputString)
        {
            return Self.containsNone(inputString);
        }

        public bool containsOnly(string inputString)
        {
            return Self.containsOnly(inputString);
        }

        public bool containsWhitespace()
        {
            return Self.containsWhitespace();
        }

        public int countMatches(string substring)
        {
            return Self.countMatches(substring);
        }

        public string deleteWhitespace()
        {
            return Self.deleteWhitespace();
        }

        public string difference(string secondString)
        {
            return Self.difference(secondString);
        }

        public bool endsWith(string suffix)
        {
            return Self.endsWith(suffix);
        }

        public bool endsWithIgnoreCase(string suffix)
        {
            return Self.endsWithIgnoreCase(suffix);
        }

        public bool equals(string secondString)
        {
            return Self.equals(secondString);
        }

        public bool equals(object stringOrId)
        {
            return Self.equals(stringOrId);
        }

        public bool equalsIgnoreCase(string secondString)
        {
            return Self.equalsIgnoreCase(secondString);
        }

        public string escapeCsv()
        {
            return Self.escapeCsv();
        }

        public string escapeEcmaScript()
        {
            return Self.escapeEcmaScript();
        }

        public string escapeHtml3()
        {
            return Self.escapeHtml3();
        }

        public string escapeHtml4()
        {
            return Self.escapeHtml4();
        }

        public string escapeJava()
        {
            return Self.escapeJava();
        }

        public static string escapeSingleQuotes(string stringToEscape)
        {
            return Implementation.escapeSingleQuotes(stringToEscape);
        }

        public string escapeUnicode()
        {
            return Self.escapeUnicode();
        }

        public string escapeXml()
        {
            return Self.escapeXml();
        }

        public static string format(string stringToFormat, List<string> formattingArguments)
        {
            return Implementation.format(stringToFormat, formattingArguments);
        }

        public static string fromCharArray(List<int> charArray)
        {
            return Implementation.fromCharArray(charArray);
        }

        public List<int> getChars()
        {
            return Self.getChars();
        }

        public static string getCommonPrefix(List<string> strings)
        {
            return Implementation.getCommonPrefix(strings);
        }

        public int getLevenshteinDistance(string stringToCompare)
        {
            return Self.getLevenshteinDistance(stringToCompare);
        }

        public int getLevenshteinDistance(string stringToCompare, int threshold)
        {
            return Self.getLevenshteinDistance(stringToCompare, threshold);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int indexOf(string substring)
        {
            return Self.indexOf(substring);
        }

        public int indexOf(string substring, int index)
        {
            return Self.indexOf(substring, index);
        }

        public int indexOfAny(string substring)
        {
            return Self.indexOfAny(substring);
        }

        public int indexOfAnyBut(string substring)
        {
            return Self.indexOfAnyBut(substring);
        }

        public int indexOfChar(int character)
        {
            return Self.indexOfChar(character);
        }

        public int indexOfChar(int character, int startIndex)
        {
            return Self.indexOfChar(character, startIndex);
        }

        public int indexOfDifference(string stringToCompare)
        {
            return Self.indexOfDifference(stringToCompare);
        }

        public int indexOfIgnoreCase(string substring)
        {
            return Self.indexOfIgnoreCase(substring);
        }

        public int indexOfIgnoreCase(string substring, int startPosition)
        {
            return Self.indexOfIgnoreCase(substring, startPosition);
        }

        public bool isAllLowerCase()
        {
            return Self.isAllLowerCase();
        }

        public bool isAllUpperCase()
        {
            return Self.isAllUpperCase();
        }

        public bool isAlpha()
        {
            return Self.isAlpha();
        }

        public bool isAlphaSpace()
        {
            return Self.isAlphaSpace();
        }

        public bool isAlphanumeric()
        {
            return Self.isAlphanumeric();
        }

        public bool isAlphanumericSpace()
        {
            return Self.isAlphanumericSpace();
        }

        public bool isAsciiPrintable()
        {
            return Self.isAsciiPrintable();
        }

        public static bool isBlank(string inputString)
        {
            return Implementation.isBlank(inputString);
        }

        public static bool isEmpty(string inputString)
        {
            return Implementation.isEmpty(inputString);
        }

        public static bool isNotBlank(string inputString)
        {
            return Implementation.isNotBlank(inputString);
        }

        public static bool isNotEmpty(string inputString)
        {
            return Implementation.isNotEmpty(inputString);
        }

        public bool isNumeric()
        {
            return Self.isNumeric();
        }

        public bool isNumericSpace()
        {
            return Self.isNumericSpace();
        }

        public bool isWhitespace()
        {
            return Self.isWhitespace();
        }

        public static string join(object iterableObj, string separator)
        {
            return Implementation.join(iterableObj, separator);
        }

        public int lastIndexOf(string substring)
        {
            return Self.lastIndexOf(substring);
        }

        public int lastIndexOf(string substring, int endPosition)
        {
            return Self.lastIndexOf(substring, endPosition);
        }

        public int lastIndexOfChar(int character)
        {
            return Self.lastIndexOfChar(character);
        }

        public int lastIndexOfChar(int character, int endIndex)
        {
            return Self.lastIndexOfChar(character, endIndex);
        }

        public int lastIndexOfIgnoreCase(string substring)
        {
            return Self.lastIndexOfIgnoreCase(substring);
        }

        public int lastIndexOfIgnoreCase(string substring, int endPosition)
        {
            return Self.lastIndexOfIgnoreCase(substring, endPosition);
        }

        public string left(int length)
        {
            return Self.left(length);
        }

        public string leftPad(int length)
        {
            return Self.leftPad(length);
        }

        public string leftPad(int length, string padStr)
        {
            return Self.leftPad(length, padStr);
        }

        public int length()
        {
            return Self.length();
        }

        public string mid(int startIndex, int length)
        {
            return Self.mid(startIndex, length);
        }

        public string normalizeSpace()
        {
            return Self.normalizeSpace();
        }

        public int offsetByCodePoints(int index, int codePointOffset)
        {
            return Self.offsetByCodePoints(index, codePointOffset);
        }

        public string remove(string substring)
        {
            return Self.remove(substring);
        }

        public string removeEnd(string substring)
        {
            return Self.removeEnd(substring);
        }

        public string removeEndIgnoreCase(string substring)
        {
            return Self.removeEndIgnoreCase(substring);
        }

        public string removeStart(string substring)
        {
            return Self.removeStart(substring);
        }

        public string removeStartIgnoreCase(string substring)
        {
            return Self.removeStartIgnoreCase(substring);
        }

        public string repeat(int numberOfTimes)
        {
            return Self.repeat(numberOfTimes);
        }

        public string repeat(string separator, int numberOfTimes)
        {
            return Self.repeat(separator, numberOfTimes);
        }

        public string replace(string target, string replacement)
        {
            return Self.replace(target, replacement);
        }

        public string replaceAll(string regExp, string replacement)
        {
            return Self.replaceAll(regExp, replacement);
        }

        public string replaceFirst(string regExp, string replacement)
        {
            return Self.replaceFirst(regExp, replacement);
        }

        public string reverse()
        {
            return Self.reverse();
        }

        public string right(int length)
        {
            return Self.right(length);
        }

        public string rightPad(int length)
        {
            return Self.rightPad(length);
        }

        public string rightPad(int length, string padStr)
        {
            return Self.rightPad(length, padStr);
        }

        public string[] split(string regExp)
        {
            return Self.split(regExp);
        }

        public string[] split(string regExp, int limit)
        {
            return Self.split(regExp, limit);
        }

        public List<string> splitByCharacterType()
        {
            return Self.splitByCharacterType();
        }

        public List<string> splitByCharacterTypeCamelCase()
        {
            return Self.splitByCharacterTypeCamelCase();
        }

        public bool startsWith(string prefix)
        {
            return Self.startsWith(prefix);
        }

        public bool startsWithIgnoreCase(string prefix)
        {
            return Self.startsWithIgnoreCase(prefix);
        }

        public string stripHtmlTags(string htmlInput)
        {
            return Self.stripHtmlTags(htmlInput);
        }

        public string substring(int startIndex)
        {
            return Self.substring(startIndex);
        }

        public string substring(int startIndex, int endIndex)
        {
            return Self.substring(startIndex, endIndex);
        }

        public string substringAfter(string separator)
        {
            return Self.substringAfter(separator);
        }

        public string substringAfterLast(string separator)
        {
            return Self.substringAfterLast(separator);
        }

        public string substringBefore(string separator)
        {
            return Self.substringBefore(separator);
        }

        public string substringBeforeLast(string separator)
        {
            return Self.substringBeforeLast(separator);
        }

        public string substringBetween(string tag)
        {
            return Self.substringBetween(tag);
        }

        public string substringBetween(string open, string close)
        {
            return Self.substringBetween(open, close);
        }

        public string swapCase()
        {
            return Self.swapCase();
        }

        public string toLowerCase()
        {
            return Self.toLowerCase();
        }

        public string toLowerCase(string locale)
        {
            return Self.toLowerCase(locale);
        }

        public string toUpperCase()
        {
            return Self.toUpperCase();
        }

        public string toUpperCase(string locale)
        {
            return Self.toUpperCase(locale);
        }

        public string trim()
        {
            return Self.trim();
        }

        public string uncapitalize()
        {
            return Self.uncapitalize();
        }

        public string unescapeCsv()
        {
            return Self.unescapeCsv();
        }

        public string unescapeEcmaScript()
        {
            return Self.unescapeEcmaScript();
        }

        public string unescapeHtml3()
        {
            return Self.unescapeHtml3();
        }

        public string unescapeHtml4()
        {
            return Self.unescapeHtml4();
        }

        public string unescapeJava()
        {
            return Self.unescapeJava();
        }

        public string unescapeUnicode()
        {
            return Self.unescapeUnicode();
        }

        public string unescapeXml()
        {
            return Self.unescapeXml();
        }

        public static string valueOf(Date dateToConvert)
        {
            return Implementation.valueOf(dateToConvert);
        }

        public static string valueOf(Datetime datetimeToConvert)
        {
            return Implementation.valueOf(datetimeToConvert);
        }

        public static string valueOf(decimal decimalToConvert)
        {
            return Implementation.valueOf(decimalToConvert);
        }

        public static string valueOf(double doubleToConvert)
        {
            return Implementation.valueOf(doubleToConvert);
        }

        public static string valueOf(int integerToConvert)
        {
            return Implementation.valueOf(integerToConvert);
        }

        public static string valueOf(long longToConvert)
        {
            return Implementation.valueOf(longToConvert);
        }

        public static string valueOf(object toConvert)
        {
            return Implementation.valueOf(toConvert);
        }

        public static string valueOfGmt(Datetime datetimeToConvert)
        {
            return Implementation.valueOfGmt(datetimeToConvert);
        }

        public void addError(Exception msg, bool escape)
        {
            Self.addError(msg, escape);
        }

        public void addError(Exception msg)
        {
            Self.addError(msg);
        }

        public string overlay(string overlay, int start, int end)
        {
            return Self.overlay(overlay, start, end);
        }

        public string stripHtmlTags()
        {
            return Self.stripHtmlTags();
        }
    }
}
