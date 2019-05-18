using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Abstract_Data_Structures
{
    public class Queue
    {
        int size = 5;
        int?[] myArray = new int?[5];
        int front = 0;
        int rear = -1;
        int itemCount = 0;
        public int? Peek()
        {
            return myArray[front];
        }
        public bool IsFull()
        {
            return itemCount == size;
        }
        public bool IsEmpty()
        {
            return itemCount == 0;
        }
        public void Enqueue(int data)
        {
            if (!IsFull())
            {
                if (rear == size - 1)
                {
                    rear = -1;
                }

                rear += 1;
                myArray[rear] = data;
                itemCount += 1;
            }
            else
            {
                Console.WriteLine("Cannot enqueue. Queue is full.");
            }
        }
        public int? Dequeue()
        {
            if (!IsEmpty())
            {
                int? temp = myArray[front];
                myArray[front] = null;
                front += 1;
                if (front == size)
                {
                    front = 0;
                }

                itemCount -= 1;

                return temp;
            }
            else
            {
                Console.WriteLine($"Cannot dequeue. Queue is empty.");
                return null;
            }
        }

        public void DisplayQueue()
        {
            Console.WriteLine($"Queue: {string.Join(',', myArray)}");
        }
    }
}
