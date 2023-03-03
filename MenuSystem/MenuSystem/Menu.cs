using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    internal class Menu
    {
        public string Title;
        private MenuItem[] menuItems = new MenuItem[10];
        private int itemCount = 0;

        public Menu(string title)
        {
            Title = title;
        }

        public void Show()
        {
            Console.WriteLine(Title + "\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(menuItems[i].Title);
            }

            Console.WriteLine("\n" + "(Tryk menupunkt eller 0 for at afslutte)");
        }

        public void AddMenuItem(string menuTitle)
        {
            MenuItem mi = new MenuItem(menuTitle);
            menuItems[itemCount] = mi;
            itemCount++;
        }

        public int SelectMenuItem()
        {
            // TODO Øvelse 2.5
        }
    }
}
