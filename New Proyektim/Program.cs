using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library1 = new Library();
            library1.Booklist.Add(new Book("Valosh", "wtcn", 35));
            library1.Booklist.Add(new Book("Valosh", "wtcn", 30));
            library1.Booklist.Add(new Book("Valosh", "wtcn", 40));
            foreach (var item in library1.Booklist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
