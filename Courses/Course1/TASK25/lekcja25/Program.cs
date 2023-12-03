namespace lekcja25
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Kolejka:");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            
            Console.WriteLine("Stos:");
            Stack<int> stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            Console.WriteLine(stos.Peek());
            Console.WriteLine(stos.Pop());
            Console.WriteLine(stos.Peek());
        }
    }
}