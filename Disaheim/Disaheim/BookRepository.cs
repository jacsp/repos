using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            return books.Find(i => i.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double total = 0;

            foreach (var book in books)
            {
                total += Utility.GetValueOfMerchandise(book);
            }

            return total;
        }
    }
}
