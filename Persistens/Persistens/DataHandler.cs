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

        public void SavePersons(Person[] persons)
        {
            StreamWriter sw = new StreamWriter(dataFileName);

            for (int i = 0; i < persons.Length; i++)
            {
                // For every person in persons[] make write a new line.
                sw.WriteLine(persons[i].MakeTitle());
            }

            sw.Close();
        }

        public Person[] LoadPersons()
        {
            string line;

            // Supports loading up to 100 people now.
            Person[] people = new Person[100];

            StreamReader sr = new StreamReader(dataFileName);

            line = sr.ReadLine();

            // Read each line one by and add it to and array.
            int i = 0;
            while (line != null)
            {
                string[] values;
                
                values = line.Split(';');

                Person person = new Person(values[0], DateTime.Parse(values[1]), double.Parse(values[2]), bool.Parse(values[3]), Int32.Parse(values[4]));

                people[i] = person;

                i++;

                // Read next line
                line = sr.ReadLine();
            }

            sr.Close();

            return people;
        }
    }
}
