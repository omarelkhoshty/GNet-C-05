using GNet_C_05;
using System.Drawing;

namespace GNet_C_05
{
    #region Question 1
    //Q01:Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
    //class Book
    //{
    //    public string Title = "C# Basics";
    //    private string password = "secret";

    //    public void ShowPassword()
    //    {
    //        Console.WriteLine(password);
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book b = new Book();

    //        Console.WriteLine(b.Title);      // OK - Title is public

    //        // Console.WriteLine(b.password);

    //        // 'Book.password' is inaccessible due to its protection level
    //        // Why: private members can only be accessed inside the class that declares them (Book).
    //        // Main is in another class (Program), so the compiler blocks it. This is encapsulation.

    //        b.ShowPassword();



    //    }
    //} 
    #endregion

    #region Question 2
    ////Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?
    //class Book
    //{
    //    internal int copiesInStock = 5;
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book b = new Book();

    //        Console.WriteLine(b.copiesInStock);   // prints 5

    //        // Yes, it compiles.
    //        // Why: internal means the member is accessible anywhere in the SAME assembly (project).
    //        // Book and Program are in the same project, so Main can access copiesInStock.
    //        // Code in a different project/assembly could NOT access it.
    //    }
    //}
    #endregion

    #region Question 3
    //Q03: Add a public string Title; field to Book. Set it and print it from Main
    //class Book
    //{
    //    public string Title;
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book b = new Book();

    //        b.Title = "Clean Code";
    //        Console.WriteLine(b.Title);
    //    }
    //}
    #endregion

    #region Question 4
    //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.

    //enum Genre
    //{
    //    Fiction,
    //    NonFiction,
    //    Science
    //}

    //class Book
    //{
    //    public Genre Genre { get; set; } 
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book b = new Book();

    //        b.Genre = Genre.Science;           
    //        Console.WriteLine(b.Genre);  


    //        Console.WriteLine((int)b.Genre); 
    //    }
    //}
    #endregion

    #region Question 5
    //Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int. 

    //enum Genre
    //{
    //    Fiction,
    //    NonFiction,
    //    Science
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine((int)Genre.Fiction);      
    //        Console.WriteLine((int)Genre.NonFiction);   
    //        Console.WriteLine((int)Genre.Science);      

    //    }
    //}
    #endregion

    #region Question 6
    //Given int genreNumber = 1;, cast it into a Genre value and print the result. 
    //enum Genre
    //{
    //    Fiction,
    //    NonFiction,
    //    Science
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int genreNumber = 1;

    //        Genre g = (Genre)genreNumber; 
    //        Console.WriteLine(g);           

    //    }
    //}
    #endregion

    #region Question 7
    // Q07: Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Genre genre = Genre.Fiction;

            string genreText = genre.ToString();
            Console.WriteLine(genreText);          

        }
    }
    #endregion




}
