using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string value, string delimiter)
    {
      
        char lastCharDelimeter = delimiter[delimiter.Trim().Length - 1];
        int indexChar = value.LastIndexOf(lastCharDelimeter);
        

        return value.Substring(indexChar + 1);
    }

   // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string value, string firstDelimiter, string secondDelimiter)
    {
        string stringAfterDelimeter = value.SubstringAfter(firstDelimiter.Trim());
        int firstIndexOfSecondDelimeter = stringAfterDelimeter.IndexOf(secondDelimiter.Trim()[0]);
        return stringAfterDelimeter.Remove(firstIndexOfSecondDelimeter).Trim();
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string value)
    {
        string logText = value.Split([':'])[1].Trim();
        return logText;
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string value)
    {
        string logText = value.Split([']'])[0].Trim();
        return logText.TrimStart('[').TrimEnd(']');
    }
}