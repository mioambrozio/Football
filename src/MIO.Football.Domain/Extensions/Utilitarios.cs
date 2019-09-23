using System.Text.RegularExpressions;

namespace MIO.Football.Domain.Extensions
{
    public static class Utilitarios
    {
        public static bool SearchEmptyOrNullOrDifNumber(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                return false;
            else if (!Regex.IsMatch("", "[0-9]{4}"))
                return false;
            else return true;
        }
    }
}