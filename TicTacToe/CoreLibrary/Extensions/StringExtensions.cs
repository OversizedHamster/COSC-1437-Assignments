//Ethan Smith

namespace CoreLibrary
{
    public static class StringExtensions
    {
        //Returns true if the passed content is null or just white space
        public static bool IsNullOrWhiteSpace(this string content)
        {
            return string.IsNullOrWhiteSpace(content);
        }

        //returns true if the passed content is null or an empty string
        public static bool IsNullOrEmpty(this string content)
        {
            return string.IsNullOrEmpty(content);
        }

        //Returns the characters of a string that are to the left of a passed index number
        public static string Left(this string content, int numCharacters)
        {
            if (content == null) return null;

            if (content.Length < numCharacters) return content;

            return content.Substring(
                0,
                numCharacters);
        }

        //Returns the characters of a string that are to the right of a passed index number
        public static string Right(this string content, int numCharacters)
        {
            if (content == null) return null;

            if (content.Length < numCharacters) return string.Empty;

            var maxIndex = content.Length - 1;

            return content.Substring(
                numCharacters,
                maxIndex);
        }
    }
}
