using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. Create a class called Books with BookName and AuthorName as members. Instantiate the class through constructor 
and also write a method Display() to display the details. 
Create an Indexer of Books Object to store 5 books in a class called BookShelf. 
Using the indexer method assign values to the books and display the same.
Hint(use Aggregation/composition)
 */


namespace ConsoleApp1
{
    public class Book //creating a Book class
    {
        //members
        public string BookName { get; }
        public string AuthorName { get; }

        //Instantiating the class
        public Book(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display() //function to display the bookname and authorname
        {
            Console.WriteLine($"Book Name: {BookName}, Author Name: {AuthorName}");
        }
    }

    public class BookShelf //another class 
    {
        private Book[] books = new Book[5]; //creating objects to store 5 books

        public Book this[int index]
        {
            get //for getting the value
            {
                if (index >= 0 && index < 5)
                {
                    return books[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set //for srtting the value
            {
                if (index >= 0 && index < 5)
                {
                    books[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();

            bookShelf[0] = new Book("The secret", "Rhonda Byrne");
            bookShelf[1] = new Book("Rich dad poor dad", "Robert T. Kiyosaki");
            bookShelf[2] = new Book("The Logic", "Jane Austen");
            bookShelf[3] = new Book("The Catcher", "J.D. Salinger");
            bookShelf[4] = new Book("1984", "George Orwell");

            for (int i = 0; i < 5; i++)
            {
                bookShelf[i].Display();
            }

            Console.Read();
        }
    }
}
