using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        public int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age
        {
            get { return age; }
            set { 
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool TreeAlive
        {
            get { return treeAlive; }
            set { treeAlive = value; }
        }

        public int NumOranges
        {
            get { return this.numOranges; }
        }

        public int OrangesEaten
        {
            get { return this.orangesEaten; }
        }

        public void OneYearPasses()
        {
            this.age++;
            if (this.age < 80) this.height += 2;
            this.treeAlive = this.age > 80;
            this.numOranges = 0;
            if (this.age > 1) this.numOranges = this.age * 5;
        }

        public void EatOrange(int count)
        {
            this.orangesEaten += count;
        }
    }
}
