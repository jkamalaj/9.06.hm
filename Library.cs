using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Library
    {
        public Library()
        {
            Products = new Product[0];
        }

        public Product[] Products;
        public Book[] Books;
        public Journal[] Journals;
        public int Count;
        private Journal item;
       public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;

        }
        public int GetJurnalsCount()
        {
            int count = 0;
            foreach(var item in Products)
            {
                if (item is Journal)
                    count++;
            }
            return count;
        }
        public int GetBooksCount()
        {
            int count = 0;
            foreach(var item in Products)
            {
                if (item is Book)
                    count++;
            }

            return count;
        }
        public void  GetProducts(Book book)
        {
            bool check;
            check = false;
            foreach (var item in Books)
            {
                if (item is Book)
                    check = true;
                Array.Resize(ref Books, Books.Length + 1);
                    Books[Books.Length - 1] = item;
            }
            check = false;
            Array.Resize(ref Journals, Journals.Length + 1);
            Journals[Journals.Length - 1] = item;
           

        }
    }
}
