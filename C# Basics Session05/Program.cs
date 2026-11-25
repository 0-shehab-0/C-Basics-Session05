using Microsoft.VisualBasic;

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

        class Book3
        {
            public string Title;
        }

        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }

        class Book4
        {
            public Genre Genre;
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
            //            Book2 book = new Book2();
            //Console.WriteLine(book.copiesInStock);

            #endregion

            #region Quistion 3
            //Add a public string Title; field to Book. Set it and print it from Main.
            //Book3 book = new Book3();

            //book.Title = " Code";

            //Console.WriteLine(book.Title);

            #endregion

            #region Quistion 4
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, 
            //assign it Genre.Science, and print it 

            //            Book4 book = new Book4();

            //book.Genre = Genre.Science;

            //Console.WriteLine(book.Genre);

            #endregion

            #region Quistion 5
            //Using the Genre enum above, print the underlying int value of 
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            #endregion

            #region Quistion 6
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.

            //int genreNumber =1;

            //Genre genre = (Genre)genreNumber;

            //Console.WriteLine(genre);

            #endregion

            #region Quistion 7
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.

            //Genre genre = Genre.Fiction;

            //string result = genre.ToString();

            //Console.WriteLine(result);

            #endregion

            #region Quistion 8
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and 
            //print the result.

            //string genreText = "Science";

            //Genre genre1= (Genre)Enum.Parse(typeof(Genre), genreText);

            //Console.WriteLine(genre);


            #endregion

            #region Quistion 8
            //Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to 
          //attempt the conversion.Print "Unknown genre" if it fails.

            string genreText = "Mystery";

            if (Enum.TryParse<Genre>(genreText, out Genre genre))
            {
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }

            #endregion


        }
    }
}
