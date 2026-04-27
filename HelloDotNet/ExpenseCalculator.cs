public static class ExpenseCalculator
{
    //     Ask user for monthly income
    // Ask user for rent
    // Ask user for food expense
    // Ask user for transportation expense
    // Calculate total expenses
    // Calculate remaining balance
    // Print result

    public static void UserExpCalc()
    {
        Console.WriteLine("Monthly Income -");
        int income = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Monthly Rent -");
        int rent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Monthly Transport expenses -");
        int transportExp = Convert.ToInt32(Console.ReadLine());

        int totalExp = rent + transportExp;

        Console.WriteLine($"Monthly income - {income}");
        Console.WriteLine($"Total Expenses - {totalExp}");
        Console.WriteLine($"Remaining balance - {income - totalExp}");

    }
}