using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Book
    {

        private string name;
        //property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //property
        private string author;
        public string Author
        {
            get => author;
            set => author = value;
        }
        //property
        private int pages;  
        public int Pages
        { get; set;
        }
        //Constructor
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


    }
}
