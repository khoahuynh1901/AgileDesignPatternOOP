namespace iterator_Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total number of Observers to be created:");
            int totalObservers = int.Parse(Console.ReadLine());

            IAggregate aggregate = new MyAggregate();

            for (int i = 0; i < totalObservers; i++)
            {
                // Create an Observer and add it to the aggregate list
                aggregate[i] = new Observer("Observer No: " + i).ObserverName;
            }

            // Get iterator
            IIterator iterator = aggregate.GetIterator();

            Console.WriteLine("Observers created and stored in the Aggregate List:");
            // Iterate through the list and display observer names
            while (!iterator.IsDone)
            {
                Console.WriteLine(iterator.CurrentItem);
                _ = iterator.NextItem;
            }

            Console.ReadLine();
        }


    }
    
}
