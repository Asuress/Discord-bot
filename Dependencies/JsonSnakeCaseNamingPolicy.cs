using System.Linq;
using System.Text.Json;

namespace Discord_bot.Dependencies
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public static SnakeCaseNamingPolicy Instance { get; } = new SnakeCaseNamingPolicy();
        public static string ToSnakeCase(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
        public override string ConvertName(string name)
        {
            // Conversion to other naming convention goes here. Like SnakeCase, KebabCase etc.
            return ToSnakeCase(name);
        }
    }
}