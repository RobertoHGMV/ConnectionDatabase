namespace ConnectionDatabase.Domain.Helpers
{
    public class ConnectionHelper
    {
        internal static string SubStringStartUntil(string value, string indexText)
        {
            var finalIndex = value?.IndexOf(indexText) ?? -1;

            return finalIndex == -1 ? value : SubStringStartUntil(value, finalIndex);
        }

        internal static string SubStringStartUntil(string value, int finalIndex)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            if (finalIndex == -1)
                return value;

            return value.Substring(0, finalIndex).Trim();
        }

        internal static string SubStringUntilTheEnd(string value, string indexText)
        {
            var indiceFinal = value?.IndexOf(indexText) ?? -1;

            return indiceFinal == -1 ? value : SubStringUntilTheEnd(value, indiceFinal);
        }

        internal static string SubStringUntilTheEnd(string value, int indexOfDay)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            return value.Substring(indexOfDay, value.Length - indexOfDay).Trim();
        }
    }
}
