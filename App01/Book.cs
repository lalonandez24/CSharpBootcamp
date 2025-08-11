using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Book
    {

        string name;
        public string author;
        public int pages;  
        public Book(string name, string author, int pages)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;
        }

        public string getDescription()
        {
            return $"{name} by {author}, {pages} pages";
        }

        public string getName()
        {
            return name;
        }   

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
