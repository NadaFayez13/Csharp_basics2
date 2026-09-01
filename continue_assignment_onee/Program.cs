namespace continue_assignment_onee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            string pagesText = "464";
            int pages = Convert.ToInt32(pagesText);
            Console.WriteLine(pages);
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
        }
    }
}
