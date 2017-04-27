using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientosAlgoritmos
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("¿Que metodo quieres usar?\n1.Insertion\n2.Selection\n3.Quicksort\n4.Mergesort\n5.Heapsort\n6.Salir");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine("Dame el numero de nombres");
                Ordenamientos<Persona> ord = new Ordenamientos<Persona>();
                Auxiliar aux = new Auxiliar(int.Parse(Console.ReadLine()));
                Persona[] array = aux.genRandomNames();
                Stopwatch stopWatch = new Stopwatch();

                string imp;
                array = aux.genRandomNames();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("¿Deseas imprimir los datos (No se recomienda para N's grandes) Y/N");
                        imp = Console.ReadLine();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array,0);
                        }
                        stopWatch.Start();
                        ord.InsertionSort(array);
                        stopWatch.Stop();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 1);
                        }
                        Console.WriteLine("Insertion " + stopWatch.ElapsedMilliseconds);
                        break;
                    case 2:
                        Console.WriteLine("¿Deseas imprimir los datos (No se recomienda para N's grandes) Y/N");
                        imp = Console.ReadLine();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 0);
                        }
                        stopWatch.Start();
                        ord.SelectionSort(array);
                        stopWatch.Stop();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 1);
                        }
                        Console.WriteLine("Selection " + stopWatch.ElapsedMilliseconds);
                        break;
                    case 3:
                        Console.WriteLine("¿Deseas imprimir los datos (No se recomienda para N's grandes) Y/N");
                        imp = Console.ReadLine();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 0);
                        }
                        stopWatch.Start();
                        ord.QuickSort(array);
                        stopWatch.Stop();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 1);
                        }
                        Console.WriteLine("Quick " + stopWatch.ElapsedMilliseconds);
                        break;
                    case 4:
                        Console.WriteLine("¿Deseas imprimir los datos (No se recomienda para N's grandes) Y/N");
                        imp = Console.ReadLine();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 0);
                        }
                        stopWatch.Start();
                        array = ord.MergeSort(array);
                        stopWatch.Stop();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 1);
                        }
                        Console.WriteLine("Merge " + stopWatch.ElapsedMilliseconds);
                        break;
                    case 5:
                        Console.WriteLine("¿Deseas imprimir los datos (No se recomienda para N's grandes) Y/N");
                        imp = Console.ReadLine();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 0);
                        }
                        
                        stopWatch.Start();
                        ord.HeapSort(array);
                        stopWatch.Stop();
                        if (imp.Equals("Y"))
                        {
                            aux.print(array, 1);
                        }
                        Console.WriteLine("Heap " + stopWatch.ElapsedMilliseconds);
                        break;
                    case 6:
                        cont = false;
                        break;
                }
            }
        }
        */
    }
}

