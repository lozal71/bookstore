using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace bookstore1.Models
{
    public class BookDBInizializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Titile = "Война и мир", Autor = "Лев Толстой", Price = 220 });
            db.Books.Add(new Book { Titile = "Отцы и дети", Autor = "Иван Тургенев", Price = 180 });
            db.Books.Add(new Book { Titile = "Чайка", Autor = "Антон Чехов", Price = 150 });
            base.Seed(db);
        }
    }
}