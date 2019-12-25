using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookstore1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Titile { get; set; }
        public string Autor { get; set; }
        public int Price { get; set; }
    }
}