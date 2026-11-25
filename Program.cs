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
    class Book
    {
        public string Title;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();

            b.Title = "Clean Code";
            Console.WriteLine(b.Title);
        }
    }
    #endregion




 
}
