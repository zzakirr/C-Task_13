using System;
using ClassLibrary1;
namespace _05042022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notebookun limiti;");
            int noteLimit = int.Parse(Console.ReadLine());
            Store store = new Store();
            store.NotebookLimit = noteLimit;
            Console.WriteLine("Notebookun sayi:");
            int noteCount = int.Parse(Console.ReadLine());
            while (noteLimit < noteCount)
            {
                Console.WriteLine("Notebookun sayi limiti kecir!");
                noteCount = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < noteCount; i++)
            {
                Console.WriteLine("Notebookun nomresi:");
                int noteno = int.Parse(Console.ReadLine());
                Console.WriteLine("Notebookun adi:");
                string name = Console.ReadLine();
                Console.WriteLine("Notebookun qiymeti:");
                double price = int.Parse(Console.ReadLine());
                Console.WriteLine("Notebookun endirimli faizi:");
                double discountpercent = int.Parse(Console.ReadLine());
                while (discountpercent < 0 || discountpercent > 100)
                {
                    Console.WriteLine("Notebookun endirim faizi sehvdi!");
                    discountpercent = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Notebookun RAMi:");
                int ram = int.Parse(Console.ReadLine());
                Console.WriteLine("Notebookun Storage-i:");
                int storage = int.Parse(Console.ReadLine());
                NoteBook noteBook = new NoteBook();
                noteBook.No = noteno;
                noteBook.Name = name;
                noteBook.Price = price * (100 - discountpercent) / 100;
                noteBook.DiscountPercent = discountpercent;
                noteBook.Storage = storage;
                noteBook.RAM = ram;
                store.AddProduct(noteBook);
            }
            Console.WriteLine("NOtebooklarin ortalama qiymeti");
            double avg = store.CalcNotebookAvg();
            Console.WriteLine(avg);




            Console.WriteLine("Phonenin limiti;");
            int phoneLimit = int.Parse(Console.ReadLine());
            store.PhoneLimit = phoneLimit;
            Console.WriteLine("Phonenin sayi:");
            int phoneCount = int.Parse(Console.ReadLine());
            while (phoneLimit < phoneCount)
            {
                Console.WriteLine("Phonenin sayi limiti kecir!");
                phoneCount = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < phoneCount; i++)
            {
                Console.WriteLine("Phonenin nomresi:");
                int phoneno = int.Parse(Console.ReadLine());
                Console.WriteLine("Phonenin adi:");
                string name = Console.ReadLine();
                Console.WriteLine("Phonenin qiymeti:");
                double price = int.Parse(Console.ReadLine());
                Console.WriteLine("Phonenin endirimli faizi:");
                double discountpercent = int.Parse(Console.ReadLine());
                while (discountpercent < 0 || discountpercent > 100)
                {
                    Console.WriteLine("Phonenin endirim faizi sehvdi!");
                    discountpercent = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Phonenin sim kart sayi:");
                byte simcount = byte.Parse(Console.ReadLine());
                Phone phone = new Phone();
                phone.No = phoneno;
                phone.Name = name;
                phone.Price = price * (100 - discountpercent) / 100;
                phone.DiscountPercent = discountpercent;
                phone.SimCount = simcount;
                store.AddProduct(phone);
            }
            foreach (var item in store.products)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Phonelerin ortalama qiymeti");
            double phAvg = store.CalcPhoneAvg();
            Console.WriteLine(phAvg);
            Console.WriteLine("Axtaris elemek istediyiniz productun nomresi:");
            int no = int.Parse(Console.ReadLine());
            store.FindByNo(no);
            Console.WriteLine($"NO:{store.FindByNo(no).No} Name:{store.FindByNo(no).Name} " +
                   $"Price:{store.FindByNo(no).Price} DiscountPercent:{store.FindByNo(no).DiscountPercent}");
        }
    }
}
