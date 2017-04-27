using System;
using System.IO;

namespace OrdenamientosAlgoritmos
{   
    class Auxiliar
    {
        string[] nombres;
        string[] apellidos;
        private int n;
        public Auxiliar(int n)
        {
            readFiles();
            this.n = n;
        }

        public Persona[] genRandomNames()
        {
            Random r = new Random();
            Persona[] random = new Persona[n];
            for(int i=0;i<n;i++)
            {
                random[i] = new Persona(nombres[r.Next(20)], apellidos[r.Next(20)], apellidos[r.Next(20)], r.Next(100));
                //Console.WriteLine(random[i]);
            }
            return random;
        }

        private void readFiles()
        {
            nombres = File.ReadAllLines("../../nombres.txt");
            apellidos = File.ReadAllLines("../../apellidos.txt");
        }

        public void print(Persona[] array,int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("Desordenado");
                    foreach (var VARIABLE in array)
                    {
                        Console.WriteLine(VARIABLE);
                    }
                    break;
                case 1:
                    Console.WriteLine("Ordenado");
                    foreach (var VARIABLE in array)
                    {
                        Console.WriteLine(VARIABLE);
                    }
                    break;
            }
        }
    }
}
