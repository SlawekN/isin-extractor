using System.Collections.Generic;

namespace ISINExtractor
{
    public interface IIsinExtract
    {
        IEnumerable<string> ExtractIsin(string input);
    }
}
