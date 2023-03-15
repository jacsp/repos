using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.height = height;
            this.isMarried = isMarried;
            this.noOfChildren = noOfChildren;
        }

        public Person(string name, DateTime birthDate, double height, bool isMarried)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.height = height;
            this.isMarried = isMarried;
            this.noOfChildren = 0;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Navnet skal indeholde mindst 1 karakter");
                } 
                else
                {
                    this.name = value;
                }
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value.Year < 1900)
                {
                    throw new Exception("Fødselsdagen skal være efter 1. Januar 1900");
                }
                else
                {
                    this.birthDate = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Højden skal være større end 0");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }

        public int NoOfChildren
        {
            get { return noOfChildren; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Antal børn må ikke være under 0");
                }
                else
                {
                    this.noOfChildren = value;
                }
            }
        }

        public string MakeTitle()
        {
            return name + ";" + birthDate.ToString("dd-MM-yyyy HH':'mm':'ss") + ";" + height.ToString() + ";" + isMarried.ToString() + ";" + noOfChildren.ToString();
        }
    }
}
