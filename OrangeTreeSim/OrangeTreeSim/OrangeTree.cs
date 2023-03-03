using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }

        public bool GetTreeAlive()
        {
            return this.treeAlive;
        }

        public int GetNumOranges()
        {
            return this.numOranges;
        }

        public int GetOrangesEaten()
        {
            return this.orangesEaten;
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
