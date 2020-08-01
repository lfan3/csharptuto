using System;

namespace RefSpace
{
    class Program
    {
        static void Main()
        {
            int num = 1;
            PassAnArgumentByRef paabr = new PassAnArgumentByRef();
            paabr.Method(ref num);
            int result = paabr.noRef(num);
            Console.WriteLine(num);
            Console.WriteLine(result);

            var bc = new BookCollection();
            bc.ListBooks();
            //!! important ref return value
            ref var book = ref bc.GetBookByTitle("Call of the Wild");
            Console.WriteLine(book.Author);
            if(book != null)
            {
                book = new Book{Title="Republic", Author="Plato"};
            }
            bc.ListBooks();
        }
    }
    //passing an arguement by ref
    class PassAnArgumentByRef
    {
        internal void Method(ref int refArgument)
        {
            refArgument = refArgument + 11;
        }
        internal int noRef(int num)
        {
            return num + 11;
        }
    }

    // a return ref value
    public class Book
    {
        public string Author;
        public string Title;
    }

    public class BookCollection
    {
        private Book[] books = {
            //?another way to create an object?
            //? how many ways to creat an object in c#?
            new Book{Title = "Call of the Wild", Author="Jack London"},
            new Book{Title="Tale of Two Cities", Author="Charles Dickens"}
        };
        private Book nobook = null;

        public ref Book GetBookByTitle(string title)
        {
            for(int i=0; i< books.Length; i++)
            {
                if(title == books[i].Title)
                    return ref books[i];
            }
            return ref nobook;
        }

        public void ListBooks()
        {
            foreach(var book in books)
            {
                Console.WriteLine($"{book.Title} is written by {book.Author}");
            }
            Console.WriteLine();
        }
    }
}