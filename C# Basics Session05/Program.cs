namespace C__Basics_Session05
{
    internal class Program
    {
        class Book
        {
            private string password = "secret";
        }

        class Book2
        {
            internal int copiesInStock = 5;
        }
        static void Main(string[] args)
        {
            #region Quistion 1
            //Book book = new Book();
            //Console.WriteLine(book.password);
            //// لان المتغير جوه الكلاس برايفت فا هيظهر ايرور
            #endregion

            #region Quistion 2
            //Add an internal int copiesInStock = 5; field to Book.
            //Print it from Main. Does it compile? 
           //why?
                        Book2 book = new Book2();
            Console.WriteLine(book.copiesInStock);

            #endregion











        }
    }
}
