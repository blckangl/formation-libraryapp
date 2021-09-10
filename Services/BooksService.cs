using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class BooksService
    {
        private List<Livre> Books;

        private int counter = 0;
        public BooksService()
        {
            Books = new List<Livre>();
            AddBook(new Livre() { Id = 1, Name = "Science Book 1", DateDeCreation = new DateTime(), Description = "Book About Science", Author = "dr. med" });
            AddBook(new Livre() { Id = 2, Name = "Science Book 2", DateDeCreation = new DateTime(), Description = "Book About Science version 2", Author = "dr. med" });
            AddBook(new Livre() { Id = 3, Name = "Harry Potter", DateDeCreation = new DateTime(), Description = "The universe of hogwarts and the story of harry potter", Author = "jk" });
            AddBook(new Livre() { Id = 4, Name = "ww1", DateDeCreation = new DateTime(), Description = "Book About the world war 1", Author = "samy" });
            AddBook(new Livre() { Id = 5, Name = "Economy", DateDeCreation = new DateTime(), Description = "Book About Economy", Author = "samy" });
        }

        public Livre AddBook(Livre book)
        {
            counter++;
            book.Id = counter;
            Books.Add(book);
            return book;
        }

        public void RemoveBook(int bookId)
        {
            Livre deletedBook = Books.Find((book) => book.Id == bookId);

            Books.Remove(deletedBook);
        }
        public List<Livre> getBooks()
        {
            return Books;
        }
    }
}
