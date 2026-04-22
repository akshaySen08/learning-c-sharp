namespace Strings
{
    class Strings
    {
        static void Main(string[] args)
        {
            // String Methods
            string myStr = "qwerty";

            Console.WriteLine(myStr);
            Console.WriteLine(myStr.Length);
            Console.WriteLine(myStr.ToUpper());
            Console.WriteLine(myStr.ToLower());

            // String Interpolation - 

            string myName = "Akshay";

            Console.WriteLine($"My name is {myName}");

            // Accessing string using indexes - 
            Console.WriteLine(myName[3]);

            // Checking Index - 
            Console.WriteLine(myName.IndexOf('y'));
            Console.WriteLine(myName.IndexOf('x'));

            // SubString method - gets the substring out of a string
            string myFullName = "Akshay Sen";
            Console.WriteLine(myFullName.Substring(6));

        }
    }
}