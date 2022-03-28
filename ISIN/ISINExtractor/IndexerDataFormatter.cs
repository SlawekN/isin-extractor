using System;
using System.Collections.Generic;
using System.Text;

namespace ISINExtractor
{
    public interface IIndexDataFormatter
    {
        public string ConvertToIndexerFormat(string input);
    }
    public class IndexerDataFormatter: IIndexDataFormatter
    {
        
        public string ConvertToIndexerFormat(string input)
        {
            throw new NotImplementedException();
        }
    }
}
