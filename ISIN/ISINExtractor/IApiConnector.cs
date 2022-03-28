using System;
using System.Collections.Generic;
using System.Text;

namespace ISINExtractor
{
    public interface IApiConnector
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="jsonLoad">
        /// { "idType": "ID_ISIN", "idValue": "US4592001014"}
        /// </param>
        /// <returns>
        /// array<string> {
        //"data": [{
        //    "figi": "BBG000NHN466",
        //    "securityType": "Common Stock",
        //    "marketSector": "Equity",
        //    "ticker": "IBMGBX",
        //    "name": "INTL BUSINESS MACHINES CORP",
        //    "exchCode": "EU",
        //    "shareClassFIGI": "BBG001S5S399",
        //    "compositeFIGI": "BBG000NHN304",
        //    "securityType2": "Common Stock",
        //    "securityDescription": "IBMGBX"
        //}, {
        //    "figi": "BBG000NRMJ71",
        //    "securityType": "Common Stock",
        //    "marketSector": "Equity",
        //    "ticker": "IBMGBX",
        //    "name": "INTL BUSINESS MACHINES CORP",
        //    "exchCode": "XL",
        //    "shareClassFIGI": "BBG001S5S399",
        //    "compositeFIGI": "BBG000NRMD01",
        //    "securityType2": "Common Stock",
        //    "securityDescription": "IBMGBX"
        //}
        /// </returns>

        public string GetIsinData(string jsonLoad);
    }
}
