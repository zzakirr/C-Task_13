using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
     public class Store
    {
        public Product[] products = new Product[0];
        public int NotebookLimit;
        public int PhoneLimit;
        public static int NoteCount = 0;
        public static int PhoneCount = 0;
        public void AddProduct(Product product)
        {
            
            
            if (product is NoteBook)
            {
                if (NoteCount < NotebookLimit)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = product;
                    NoteCount++;
                }
            }
            if (product is Phone)
            {
                if (PhoneCount < PhoneLimit)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = product;
                    PhoneCount++;
                }
            }
        }
        public Product FindByNo(int no)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                    return products[i];
            }
            return null;
        }
        public double CalcNotebookAvg()
        {
            int NoteCount = 0;

            double sum = 0;
            foreach (var item in products)
            {
                if (item is NoteBook)
                {
                    sum += item.Price;
                    NoteCount++;
                }
            }
            if (NoteCount == 0)
                return 0;
            return sum / NoteCount;

        }
        public double CalcPhoneAvg()
        {
            int PhoneCount = 0;

            double sum = 0;
            foreach (var item in products)
            {
                if (item is Phone)
                {
                    sum += item.Price;
                    PhoneCount++;
                }
            }
            if (PhoneCount == 0)
                return 0;
            return sum / PhoneCount;

        }


    }
}
