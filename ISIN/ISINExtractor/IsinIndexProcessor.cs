using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ISINExtractor
{
    /// <summary>
    /// For given ISIN, makes API call and processed response links to given Indexer
    /// </summary>
    public class IsinIndexProcessor
    {
        private IApiConnector apiConnector;
        private IIndexDataFormatter formatter;
        private ISearchIndexer searchIndexer;
        private IIsinExtract isinExtract;

        public IsinIndexProcessor(
            IApiConnector apiConnector, 
            IIndexDataFormatter formatter,
            ISearchIndexer searchIndexer,
            IIsinExtract isinExtract)
        {
            this.apiConnector = apiConnector;
            this.formatter = formatter;
            this.searchIndexer = searchIndexer;
            this.isinExtract = isinExtract;
        }

        public List<string> Process()
        {
            var isinCodes = isinExtract.ExtractIsin("").ToList();
            List<string> indexStatuses = new List<string>();
            
            foreach(string iCode in isinCodes)
            {
                var isinApiResult = apiConnector.GetIsinData(iCode);
                var formatedData = formatter.ConvertToIndexerFormat(isinApiResult);

                string indexStatus = searchIndexer.IndexDocument(formatedData);

                indexStatuses.Append(indexStatus);
            }
            return indexStatuses;
        }
    }
}
