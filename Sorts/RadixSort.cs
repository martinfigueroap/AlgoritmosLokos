using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrdenamientosAlgoritmos
{
    class RadixSort
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();
            Random r = new Random();
            Console.WriteLine("De cuantos digitos quieres los numeros");
            int k = int.Parse(Console.ReadLine());
            string sk = "D" + k;
            Console.WriteLine("Cuantos numeros quieres");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue((r.Next((int)Math.Pow(10, k) - 1).ToString(sk)));
            }
            foreach (var VARIABLE in queue)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine();
            queue = Radix(3, queue);
            foreach (var VARIABLE in queue)
            {
                Console.WriteLine(VARIABLE);
            }

        }

        public static Queue<string> Radix(int k, Queue<string> queue) { 
        
            Queue<string>[] queues=new Queue<string>[10];
            for (int i = 0; i < queues.Length; i++)
            {
                queues[i]=new Queue<string>();
            }
            for (int i = k-1; i >=0; i--)
            {
                Console.WriteLine();
                while (queue.Any())
                {
                    string temp = queue.Dequeue();
                    char intc = temp.ToCharArray()[i];//charAt(i) Java
                    queues[int.Parse(""+intc)].Enqueue(temp);
                }
                
                foreach (Queue<string> queue1 in queues)
                {
                    while (queue1.Any())
                    {
                        queue.Enqueue(queue1.Dequeue());
                    }
                }
            }

            return queue;

        }
    }
}
