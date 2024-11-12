using System.Text.Json;

public class ExpenseController
{
  private readonly string _filePath = "expenses.json";
  private List<Expense> _expenses;

  public ExpenseController()
  {
    if (File.Exists(_filePath))
    {
      //Load existing expenses from file, if available 
      var json = File.ReadAllText(_filePath);
      _expenses = JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();
    }
    else
    {
      _expenses = new List<Expense>();
    }
  }

  // Add a new expense
  public void AddExpense(Expense expense)
  {
    expense.Id = _expenses.Count + 1;
    _expenses.Add(expense);
    SaveChanges();
  }

  // Get all expenses
  public List<Expense> GetAllExpenses() => _expenses;

  // Save changes to the file
  private void SaveChanges()
  {
    var json = JsonSerializer.Serialize(_expenses, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(_filePath, json);
  }
}