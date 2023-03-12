using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;

        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }

        public string DataFileName
        {
            get { return dataFileName; }
        }

        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(dataFileName);

            sw.Write(person.MakeTitle());

            sw.Close();
        }

        public Person LoadPerson()
        {
            string line;
            string[] values;

            StreamReader sr = new StreamReader(dataFileName);

            line = sr.ReadLine();

            sr.Close();

            values = line.Split(";");

            // TODO Lav en mere error proof parsing af strings
            Person person = new Person(values[0], DateTime.Parse(values[1]), double.Parse(values[2]), bool.Parse(values[3]), Int32.Parse(values[4]));
            
            return person;
        }
    }
}
