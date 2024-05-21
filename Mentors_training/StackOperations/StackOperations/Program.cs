namespace StackOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Implementation implementation = new Implementation();
            while (true)
            {
                InputOutput inputOutput = new InputOutput();
                int useroption = inputOutput.ReadUserOption();                
                switch (useroption)
                {
                    case (int)InputOutput.Menu.Empty:
                        implementation.IsEmpty();
                        break;
                    case (int)InputOutput.Menu.push:
                        implementation.Initialize();
                        break;
                    case (int)InputOutput.Menu.full:
                        implementation.IsFull();
                        break;
                    case (int)InputOutput.Menu.pop:
                        implementation.Remove();
                        break;
                    case (int)InputOutput.Menu.popSpecificElement:
                        int elementToRemove = inputOutput.ElementRemove();
                        implementation.RemoveAt(elementToRemove);
                        break;
                }
            }
        }
    }
}
