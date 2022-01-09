using System;
using System.Collections.Generic;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib1 = new Library();
            lib1.BookList.Add(new Book("", "", 250));
            lib1.BookList.Add(new Book("", "", 250));
            lib1.BookList.Add(new Book("", "", 250));
            lib1.BookList.Add(new Book("", "", 250));
            lib1.BookList.Add(new Book("", "", 250));
            lib1.BookList.Add(new Book("", "", 250));
            lib1.BookList.Add(new Book("", "", 250));
            lib1.BookList.Add(new Book("", "", 250));



            Console.WriteLine("----------------All Books---------------");
            foreach (var item in lib1.BookList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            lib1.RemoveByNo("");
            Console.WriteLine("-----------------------------------------");

            foreach (var item in lib1.BookList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            foreach (var book in lib1.FindAllBooksByName(""))
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Adi ve ya Muellifi axtarilan kitablar(axtaris edilen => )");

            foreach (var book in lib1.SearchBooks(""))
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Sehife araligina gore kitab axtarisi(daxil edilen=> ");
            foreach (var book in lib1.FindAllBooksByPageCountRange(50, 150))
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Kitab adina gore silme silinen kitab =>");
            lib1.RemoveAllBookByName("");

            foreach (var book in lib1.BookList)
            {
                Console.WriteLine(book);
            }













        }




    }
    }
}
