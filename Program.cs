namespace Minioppgave_MVC;

class Program
{
    static void Main(string[] args)
    {
        var controller = new ExpenseController();
        var view = new ExpenseView();

        while (true)
        {
            view.ShowMainMenu();
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var newExpense = view.GetExpenseDetails();
                    controller.AddExpense(newExpense);
                    Console.WriteLine("Expense added successfully! Press any key to return to main menu.");
                    Console.ReadKey();
                    break;
                case "2":
                    var expenses = controller.GetAllExpenses();
                    view.DisplayExpenses(expenses);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
