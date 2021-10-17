using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ReSharper disable once CheckNamespace - do not change
namespace CsvHelperUnitTestProject
{
    public partial class MainTest
    {
        private readonly string CustomerReadFileName =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Customers.csv");

        private readonly string CustomerWriteFileName = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomersWrite.csv");

        /// <summary>
        /// Perform initialization before test runs using assertion on current test name.
        /// </summary>
        [TestInitialize]
        public void Initialization()
        {
            if (TestContext.TestName == nameof(WriteCustomersDefault))
            {
                if (File.Exists(CustomerWriteFileName))
                {
                    File.Delete(CustomerWriteFileName);
                }
            }
        }

        /// <summary>
        /// Perform cleanup after test runs using assertion on current test name.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {

        }
        /// <summary>
        /// Perform any initialize for the class
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
    }
}
