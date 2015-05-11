using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WorldsSmallestBookstore.Server.Models;

namespace WorldsSmallestBookstore.Models
{

    public class SampleData : DropCreateDatabaseAlways<BookstoreEntities>
    {
        private static Bookseller Add(BookstoreEntities context, Bookseller item)
        {
            context.Booksellers.Add(item);
            return item;
        }
        private static Book Add(BookstoreEntities context, Book item)
        {
            context.Books.Add(item);
            return item;
        }
        private static Author Add(BookstoreEntities context, Author item)
        {
            context.Authors.Add(item);
            return item;
        }
        private static Publisher Add(BookstoreEntities context, Publisher item)
        {
            context.Publishers.Add(item);
            return item;
        }
        private static Customer Add(BookstoreEntities context, Customer item)
        {
            context.Customers.Add(item);
            return item;
        }
        protected override void Seed(BookstoreEntities context)
        {
            GenerateSampleData(context);
 
            context.SaveChanges();
        }

        public static void GenerateSampleData(BookstoreEntities context)
        {
            var jazz = Add(context, new Bookseller { Name = "Jazz" });
            var metal = Add(context, new Bookseller { Name = "Metal" });
            var alternative = Add(context, new Bookseller { Name = "Alternative" });
            var disco = Add(context, new Bookseller { Name = "Disco" });


            var author1 = Add(context, new Author { FirstName = "Tom" });
            var author2 = Add(context, new Author { FirstName = "Dick" });
            var author3 = Add(context, new Author { FirstName = "Harry" });

            var publisher1 = Add(context, new Publisher { Name = "McGraw" });
            var publisher2 = Add(context, new Publisher { Name = "Morrow" });

            var book1 = Add(context, new Book { Title = "All that Jazz", Author = author1, Publisher = publisher1 });
            var book2 = Add(context, new Book { Title = "It is heavy, that's my metal", Author = author1, Publisher = publisher2 });
            var book3 = Add(context, new Book { Title = "It must be something else", Author = author2, Publisher = publisher1 });
            var book4 = Add(context, new Book { Title = "The life and times of the Duck", Author = author3, Publisher = publisher2 });

            var customer1 = Add(context, new Customer { ContactName = "Peter" });
            var customer2 = Add(context, new Customer { ContactName = "Paul" });
            var customer3 = Add(context, new Customer { ContactName = "Mary" });
        }

    }

}