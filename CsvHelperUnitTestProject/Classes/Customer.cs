using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace CsvHelperUnitTestProject.Classes
{
    public class Customer
    {
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int ContactId { get; set; }
        public int CountryIdentifier { get; set; }
        public string Phone { get; set; }

        public override string ToString() => $"{CustomerIdentifier,-4}{CompanyName}";


    }
}
