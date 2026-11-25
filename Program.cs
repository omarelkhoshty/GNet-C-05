namespace GNet_C_05
{
    #region Question 1
    //Q01:Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
    class Book
    {
        public string Title = "C# Basics";
        private string password = "secret";

        public void ShowPassword()
        {
            Console.WriteLine(password);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();

            Console.WriteLine(b.Title);      // OK - Title is public

            // Console.WriteLine(b.password);

            // 'Book.password' is inaccessible due to its protection level
            // Why: private members can only be accessed inside the class that declares them (Book).
            // Main is in another class (Program), so the compiler blocks it. This is encapsulation.

            b.ShowPassword();



        }
    } 
    #endregion
}
