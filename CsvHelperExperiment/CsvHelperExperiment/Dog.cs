using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace CsvHelperExperiment
{
    public class Dog
    {
        public string PedigreeNumber { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public Dog(string pedigreeNumber, string name, string sex)
        {
            PedigreeNumber = pedigreeNumber;
            Name = name;
            Sex = sex;
        }
    }
}
