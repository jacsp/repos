using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ClosedXMLTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\jacob\Downloads\HundeDataExcelSmall.xlsx";
            string worksheetName = "Sheet1";

            var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheet(worksheetName);

            foreach (var row in worksheet.RowsUsed().Skip(1))
            {
                var name = row.Cell(4).Value.ToString();
                var sex = row.Cell(19).Value.ToString();
                var pedigree = row.Cell(2).Value.ToString();

                Dog dog = new(name, sex, pedigree);

                Console.WriteLine(dog.Name + " " + dog.Sex + " " + dog.PedigreeNumber);
            }
        }



        public class Dog
        {
            public string Name { get; set; }
            public string Sex { get; set; }
            public string PedigreeNumber { get; set; }

            public Dog(string name, string sex, string pedigreeNumber)
            {
                Name = name;
                Sex = sex;
                PedigreeNumber = pedigreeNumber;
            }
        }
    }
}