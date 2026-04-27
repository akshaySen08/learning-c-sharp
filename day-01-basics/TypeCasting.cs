namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting (automatically) - converting a smaller type to a larger type size
            int myInt = 9;
            double myDouble = myInt; // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9.0

            // Explicit Casting (manually) - converting a larger type to a smaller type size
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2; // Manual casting: double to int
            string myString = Convert.ToString(myInt2); // Convert int to string

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9
            Console.WriteLine(myString);    // Outputs "9"
        }
    }
}