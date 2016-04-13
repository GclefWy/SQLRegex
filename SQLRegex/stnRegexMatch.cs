using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString stnRegexMatch(string source, string match, string result)
    {
        // 在此处放置代码
        try
        {
            return new SqlString(Regex.Match(source, match).Success ? Regex.Match(source, match).Result(result) : source);
        }
        catch
        {
            return null;
        }
    }

    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString stnRegexMatch2(string source, string match, string result, string failure)
    {
        // 在此处放置代码
        try
        {
            return new SqlString(Regex.Match(source, match).Success ? Regex.Match(source, match).Result(result) : failure);
        }
        catch
        {
            return null;
        }
    }

    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlBoolean stnIsDate(string d)
    {
        // 在此处放置代码
        try
        {
            return new SqlBoolean(Regex.Match(d, @"^(?:(?!0000)[0-9]{4}([-/.]?)(?:(?:0?[1-9]|1[0-2])\1(?:0?[1-9]|1[0-9]|2[0-8])|(?:0?[13-9]|1[0-2])\1(?:29|30)|(?:0?[13578]|1[02])\1(?:31))|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)([-/.]?)0?2\2(?:29))$").Success);
        }
        catch
        {
            return false;
        }
    }

    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString stnIF(Boolean c, string t, string f)
    {
        try
        {
            return new SqlString(c ? t : f);
        }
        catch
        {
            return null;
        }
    }

}
