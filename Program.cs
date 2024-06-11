namespace Assignment6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Stack intStack = new Stack();

            foreach (int i in ints)
            {
                intStack.Push(i);
            }

            Console.WriteLine("Contents of array:");
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            intStack.PrintStack();

            Console.WriteLine("Item popped from stack: {0}", intStack.Pop());

            intStack.PrintStack();
        }
    }
}
