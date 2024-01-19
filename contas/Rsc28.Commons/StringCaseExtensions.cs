using System.Text.RegularExpressions;

namespace Rsc28.Commons;
public static class StringExtensions
{
    public static string ToKebabCase(this string input)
    {
        if (string.IsNullOrEmpty(input)) { return input; }

        var startUnderscores = Regex.Match(input, @"^-+");
        return startUnderscores + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1-$2").ToLower();
    }

    public static string ToSnakeCase(this string input)
    {
        if (string.IsNullOrEmpty(input)) { return input; }

        var startUnderscores = Regex.Match(input, @"^_+");
        return startUnderscores + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
    }
}
