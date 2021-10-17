using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelperUnitTestProject.Base;
using CsvHelperUnitTestProject.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsvHelperUnitTestProject
{

    [TestClass]
    public partial class MainTest : TestBase
    {
        /// <summary>
        /// Basic read by type, <see cref="Customer"/>
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.CsvReader)]
        public void ReadCustomersDefault()
        {
            using var reader = new StreamReader(CustomerReadFileName);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Customer>().ToList();
            Assert.AreEqual(records.Count,16);

            foreach (var customer in records.OrderBy(cust => cust.CompanyName))
            {
                Console.WriteLine($"{customer}");
            }

        }

        /// <summary>
        /// Read from pre-done file, write to new file
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.CsvReader)]
        public void WriteCustomersDefault()
        {
            int expected = 12;

            using StreamReader reader = new(CustomerReadFileName);
            using CsvReader csvReader = new(reader, CultureInfo.InvariantCulture);
            var records = csvReader.GetRecords<Customer>().ToList();

            using StreamWriter writer = new(CustomerWriteFileName);
            using CsvWriter csvWriter = new(writer, CultureInfo.InvariantCulture);

            csvWriter.WriteRecords((IEnumerable)records.Where(customer => customer.CustomerIdentifier > 16));
            csvWriter.Dispose();

            Assert.IsTrue(File.ReadAllLines(CustomerWriteFileName).Length == expected);
        }
    }
}
