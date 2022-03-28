using System;
using System.Text.RegularExpressions;

namespace ISINExtractor
{

    /// <summary>
    /// 
    /// ISIn Extractor from given string:
    ///     1. Defining expected outputs for a given string
    ///     2. Definig behavior of a class for edge or exceptional cases
    /// Define interfaces for ISIN extractor. 
    /// 
    /// ApiConnector:
    /// 
    ///     1. test:
    ///         1. testing method input (if it contatain valid ISIN)
    ///         2.testig of ApiConnector paylod: 
    ///  Define Interface (building abstraction)
    /// Wrte class implementiaion for Open FIGI api
    /// 
    /// 
    /// Api Output parser:
    ///     1. Respoinsibilitty: building json ready for indexing
    ///     
    /// DTO OpenFigiObbject 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
