namespace continue_assignment_onee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
          //  Console.WriteLine(pages);
            #endregion

            #region Question 8
            /*Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";
            use int.TryParse() to safely try converting it, and print "Invalid number" if it fails */
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            bool parsed = int.TryParse(badText, out int bad);
            if (!parsed)
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            #region Question 9
            //Given int pages = 464;, convert it into a string using ToString() and print its type using  GetType() to prove it's now a string.
            int pages=464;
            string string_pages = pages.ToString();
            Console.WriteLine(string_pages.GetType());
            #endregion

            #region Question 10
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            object boxedCopies = copies; 
            Console.WriteLine(boxedCopies);

            int unboxedCopies = (int)boxedCopies;
            Console.WriteLine(unboxedCopies);
            #endregion

        }
    }
}
