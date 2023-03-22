using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        string itemId;
        string title;
        double price;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Book(string itemId, string title, double price)
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }

        public Book(string itemId, string title) : this(itemId, title, 0) { }

        public Book(string itemId) : this(itemId, "", 0) { }

        public override string ToString()
        {
            return $"ItemId: {itemId}, Title: {title}, Price: {price}";
        }
    }
}
