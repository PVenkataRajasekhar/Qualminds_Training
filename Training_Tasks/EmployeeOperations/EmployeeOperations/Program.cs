namespace ArrayListDemo;

public enum MenuOptions
{
    Add,
    Remove,
    Update,
    Get,
    Quit
}

 public class Program
    {
    DoOperations doOperations = new DoOperations();
    EmployeeOperations employeeOperations = new EmployeeOperations();
    public void Receive(int userOption)
    {
            MenuOptions menuOption = (MenuOptions)userOption;
            switch (menuOption)
            {
                case MenuOptions.Add:
                    doOperations.Add();
                    break;
                case MenuOptions.Remove:
                    doOperations.Remove();
                    break;
                case MenuOptions.Update:
                    doOperations.Update();
                    break;
                case MenuOptions.Get:
                    doOperations.GetAll();
                    break;
                default:
                    Console.WriteLine("Invalid Input!!");
                    break;
            }
    }

        public  void TakeUserInput()
        {
            

            while (true)
            {
                Console.WriteLine($"Choose any method ");
                Console.WriteLine($"0 for {MenuOptions.Add}");
                Console.WriteLine($"1 for {MenuOptions.Remove}");
                Console.WriteLine($"2 for {MenuOptions.Update}");
                Console.WriteLine($"3 for {MenuOptions.Get}");
                Console.WriteLine($"4 for {MenuOptions.Quit}");
                Console.WriteLine("Enter one number : ");
                int userOption = Convert.ToInt32(Console.ReadLine());
                if (userOption == 4)
                {
                    break;
                }

                Receive(userOption);
            }
        }

        public static void Main(string[] args)
        {
        Program program = new Program();
        program.TakeUserInput();
        }
    }
