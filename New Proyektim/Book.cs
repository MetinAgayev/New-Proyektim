using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Book
    {
        private int Count = 0;
        public string Code { get; set; }               
    
        public string Name { get; set; }
          
 
        public string AuthorName { get; set; }
     
        public int Pagecount { get; set; }
   
       
   
        public Book(string name,string authorname,int pagecount)
        {
            Count++;
            //Code += Name.Substring(0, 2) + Count;
            Name = name;
            AuthorName = authorname;
            Pagecount = pagecount;
        }
    }
}
