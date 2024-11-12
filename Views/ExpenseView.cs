public class ExpenseView
{
  // Method to display the main menu
    public void ShowMainMenu()
    {
      Console.Clear();
      Console.WriteLine("Expense Tracker");
      Console.WriteLine("1. Add Expense");
      Console.WriteLine("2. View All Expenses");
      Console.WriteLine("3. Exit");
      Console.Write("Choose an option: ");
    }

    //Method to display expenses in a formatted way
    public void DisplayExpenses(List<Expense> expenses)
    {
      Console.Clear();
      Console.WriteLine("All Expenses:");
      Console.WriteLine("ID | Date      | Amount  | Category   | Description");
      foreach (var expense in expenses)
      {
        Console.WriteLine($"{expense.Id}  | {expense.Date.ToShortDateString()} | {expense.Amount} | {expense.Description}");
      }
      Console.WriteLine("Press any key to return to main menu.");
      Console.ReadKey();
    }

    // Method to promt for expense details when adding a new expense
    public Expense GetExpenseDetails()
    {
      Console.Clear();
      Console.WriteLine("Enter Date (YYYY-MM-DD): ");
      DateTime date = DateTime.Parse(Console.ReadLine());

      Console.WriteLine("Ener Amount: ");
      decimal amount = decimal.Parse(Console.ReadLine());

      Console.WriteLine("Enter Category: ");
      string? category = Console.ReadLine();

      Console.WriteLine("Enter Description (optional): ");
      string? description = Console.ReadLine();

      return new Expense
      {
        Date = date,
        Amount = amount,
        Category = category,
        Description = description
      };
    }
  }
