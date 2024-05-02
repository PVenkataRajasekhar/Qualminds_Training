namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayLists arrayLists = new ArrayLists();
            arrayLists.Add();
            arrayLists.Update();
            arrayLists.Delete();
            arrayLists.Reverse();
            arrayLists.Sort();
            arrayLists.Contains();
            arrayLists.Clone();
            Hashtables hashtables = new Hashtables();
            hashtables.Add();
            hashtables.Update();
            hashtables.Delete();
            hashtables.Count();
            hashtables.Contains();
            Stacks stacks = new Stacks();
            stacks.push();
            stacks.pop();
            stacks.contains();
            stacks.count();
            Queues queues = new Queues();
            queues.enqueue();
            queues.dequqeue();
            queues.contains();
            queues.count();
            SortedLists sortedLists = new SortedLists();
            sortedLists.Add();
            sortedLists.Delete();
            sortedLists.count();
            sortedLists.contains();
        }
    }
}
