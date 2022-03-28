using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ISINExtractor
{
    public class IsinExtractor : IIsinExtract
    { 
        public IEnumerable<string> ExtractIsin(string input)
        {
            var regex = new Regex("([A-Z]{2})([A-Z0-9]{9})([0-9]{1})");

            var regexMatch = regex.Matches(input);

            foreach (Match match in regexMatch)
            {
                yield return match.Value;
            }
        }
    }
}
