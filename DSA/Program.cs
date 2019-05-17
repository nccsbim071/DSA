using System;

namespace DSA
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue queue = new Queue();

            //Enqueue
            queue.Enqueue(6);
            queue.Enqueue(2);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(12);
            queue.DisplayQueue();

            //Dequeue
            queue.Dequeue();
            queue.Dequeue();
            queue.DisplayQueue();

            //Enqueue
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.DisplayQueue();

            int? temp = queue.Dequeue();
            Console.WriteLine($"Dequeue: {(temp.HasValue ? temp.Value.ToString() : string.Empty)}");
            temp = queue.Dequeue();
            Console.WriteLine($"Dequeue: {(temp.HasValue ? temp.Value.ToString() : string.Empty)}");

            //Enqueue
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.DisplayQueue();


            temp = queue.Dequeue();
            Console.WriteLine($"Dequeue: {(temp.HasValue ? temp.Value.ToString() : string.Empty)}");
            temp = queue.Dequeue();
            Console.WriteLine($"Dequeue: {(temp.HasValue ? temp.Value.ToString() : string.Empty)}");
            temp = queue.Dequeue();
            Console.WriteLine($"Dequeue: {(temp.HasValue ? temp.Value.ToString() : string.Empty)}");
            temp = queue.Dequeue();
            Console.WriteLine($"Dequeue: {(temp.HasValue ? temp.Value.ToString() : string.Empty)}");
            temp = queue.Dequeue();
            Console.WriteLine($"Dequeue: {(temp.HasValue ? temp.Value.ToString() : string.Empty)}");            

            Console.ReadKey();
        }

    }
}
