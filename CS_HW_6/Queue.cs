using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_6
{
    class QueueClass
    {
        private Queue<string> queue = new Queue<string>();

        public void AddCustomer(string name)
        {
            queue.Enqueue(name);
        }

        public void ServeCustomer()
        {
            if (queue.Count > 0)
            {
                string currentCustomer = queue.Dequeue();
                Console.WriteLine($"Обслуживается: {currentCustomer}");
            }
            else
            {
                Console.WriteLine("Очередь пуста");
            }
        }

        public int GetQueueCount()
        {
            return queue.Count;
        }
    }
}
