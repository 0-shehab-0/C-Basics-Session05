namespace C__Basics_Session05
{
    internal class Program
    {
        class Book
        {
            private string password = "secret";
        }

        static void Main(string[] args)
        {
            #region Quistion 1
            Book book = new Book();
            Console.WriteLine(book.password);
            // لان المتغير جوه الكلاس برايفت فا هيظهر ايرور
            #endregion
        }
    }
}
