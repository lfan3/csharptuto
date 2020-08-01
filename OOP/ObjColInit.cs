using System;
using System.Collections.Generic;

namespace ObjCreateSpace
{
    class Program
    {
        static void Main()
        {
            NewBook nb = new NewBook("Charles", "Frog is a joke");
            nb.display();

            BookCollection bc = new BookCollection();
            List<Book> bl1 = bc.booklist();
            List<Book> bl2 = bc.newbooklist();
            displayList(bl1);
            displayList(bl2);
            
        }
        public static void displayList(List<Book> Booklist)
        {
            foreach(Book b in Booklist)
            {
                Console.WriteLine(b.Title);
            }
        }
        public class Book
        {
            public string Author;
            public string Title;
            public int TotalArticle{get; set;}
        }
        public class BookCollection
        {
            List<Book> Booklist = new List<Book>();
            //! voir la différence entre book1 et book2, new Book{} or new Book(){}
            //Object initializer: without constructor;
            //initialize the value of fields or properties of a class!
            Book book1 = new Book{Title = "Call of the Wild", Author="Jack London", TotalArticle=10};
            Book book2 = new Book(){Title="Tale of Two Cities", Author="Charles Dickens", TotalArticle=8};
            public List<Book> booklist()
            {
                Booklist.Add(book1);
                Booklist.Add(book2);
                return Booklist;
            }

            public List<Book> newbooklist()
            {
                //Collection Initializer: without bassby Booklist.Add();
                List<Book> Booklist = new List<Book>(){book1, book2};
                return Booklist;
            }
        }
        public class NewBook
        {
            public NewBook(string author_name, string title){
                Author = author_name;
                Title = title;
            }
            public string Author{get; set;}
            public string Title{get; set;}
            public void display()
            {
                Console.WriteLine($"{Author} is the Author of {Title}");
            }
        }
    }
}
    