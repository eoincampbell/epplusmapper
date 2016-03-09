using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPPlusMapper.Core;
using EPPlusMapper.Tests.Helpers;
using EPPlusMapper.Tests.Mappers;
using EPPlusMapper.Tests.Models;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace EPPlusMapper.Tests
{
    [TestFixture]
    public class MappingTest
    {
        [Test]
        public void DoTest()
        {
            List<Simple> s = new List<Simple>
            {
                StubGenerator.CreateSimple(),
                StubGenerator.CreateSimple2()
            };

            SimpleMapper sm = new SimpleMapper();
            
            var results = sm.GenerateOutput(s);

            //Assert.AreEqual(1, results[0]["Custom Id"]);
            //Assert.AreEqual("Eoin", results[0]["Custom Name"]);

            EPPlusWriter.Write(results, "C:\\temp\\epplus\\test1.xlsx");

            Debug.WriteLine(results);
        }

        [Test]
        public void DoTest2()
        {
            List<Nested> s = new List<Nested>
            {
                StubGenerator.CreateNested()
            };

            NestedMapper sm = new NestedMapper();

            var results = sm.GenerateOutput(s);

            //Assert.AreEqual("Eoin", ((IDictionary<string, object>)results[0])["Custom First Name"]);

            EPPlusWriter.Write(results, "C:\\temp\\epplus\\test2.xlsx");
        }

        [Test]
        public void DoTest3()
        {
            List<CollectionItem> s = new List<CollectionItem>
            {
                StubGenerator.CreateCollectionItem()
            };

            CollectionItemMapper sm = new CollectionItemMapper();
            
            var results = sm.GenerateOutput(s);

            Assert.AreEqual("Eoin", ((IDictionary<string, object>)results[0])["Parent Name"]);
            Assert.AreEqual("John,Mary", ((IDictionary<string, object>)results[0])["Child Names"]);

            EPPlusWriter.Write(results, "C:\\temp\\epplus\\test3.xlsx");

        }


    }




}
