namespace TakingUserInput
{
    class TakingUserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name -");

            string name = Console.ReadLine();

            Console.WriteLine("Your name is " + name);

            Console.WriteLine(Math.Abs(-4.7));
        }
    }
}