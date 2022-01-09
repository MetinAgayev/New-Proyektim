using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Book
    {
        private static int Count = 0;
        public string Code {get;set;}

        public string Name { get; set; }
          
 
        public string AuthorName { get; set; }
     
        public int Pagecount { get; set; }



        public Book(string name, string authorname, int pagecount)
        {
            Name = name;
            AuthorName = authorname;
            Pagecount = pagecount;
            Count++;
            Code = Name.Substring(0, 2) + Count;
        }
        public override string ToString()
        {
            return $"{Code} {Name} {AuthorName} {Pagecount}";
        }
    }
}
