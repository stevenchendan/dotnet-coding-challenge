using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using dotnet_code_challenge.FileParsing;
using Xunit;

namespace dotnet_code_challenge.Test.FileParsingTests
{
    public class FileParserTest
    {
        private readonly string _xmlTestData;
        private readonly string _jsonTestData;

        public FileParserTest()
        {
            _xmlTestData = File.ReadAllText("../../../TestFeedData/Xml_ValidResponse.xml");
            _jsonTestData = File.ReadAllText("../../../TestFeedData/Wolferhampton_Race1.json");
        }

        //TODO implement unit test
        [Fact]
        public void GetHorsesFromXmlFile()
        {
            
        }

        [Fact]
        public void GetHorsesFromJsonFile()
        {

        }
    }
}
