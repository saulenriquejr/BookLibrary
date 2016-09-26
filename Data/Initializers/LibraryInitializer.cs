using DTOs;
using System.Collections.Generic;

namespace Data.TableInitializers
{
    public class LibraryInitializer : System.Data.Entity.CreateDatabaseIfNotExists<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var books = new List<Book>
            {
                new Book { Name = "The Hunger Games" , Author = "Suzanne Collins ", Category = "Action" },
                new Book { Name = "Harry Potter and the Order of the Phoenix" , Author = "J.K. Rowling", Category = "Fantasy" },
                new Book { Name = "To Kill a Mockingbird" , Author = "Harper Lee", Category = "Drama" },
                new Book { Name = "Pride and Prejudice" , Author = "Jane Austen", Category = "Romance" },
                new Book { Name = "Twilight" , Author = "Stephenie Meyer", Category = "Romance" },
                new Book { Name = "The Chronicles of Narnia" , Author = "C.S. Lewis", Category = "Fantasy" },
                new Book { Name = "Animal Farm" , Author = "George Orwell", Category = "Science Fiction" },
                new Book { Name = "The Book Thief" , Author = "Markus Zusak", Category = "Historical" },
                new Book { Name = "Gone with the Wind" , Author = "Margaret Mitchell", Category = "Romance" },
                new Book { Name = "The Giving Tree" , Author = "Shel Silverstein", Category = "Childrens" }
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

        }
    }
}
