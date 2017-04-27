using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientosAlgoritmos
{
    class Ordenamientos <T> where T:IComparable<T> 
    {
        public Ordenamientos()
        {
            
        }
        //Selection Sort
        public void SelectionSort(T[] array)
        {
            for (int i = 0; i < (array.Length - 1); i++)
            {
                int small = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j].CompareTo(array[small]) < 0)
                        small = j;
                T temp = array[small];
                array[small] = array[i];
                array[i] = temp;
            }
        }
        //Insertion sort
        public void InsertionSort(T[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                T key = array[j];
                int i = j - 1;
                while (i > 0 && array[i].CompareTo(key) > 0)
                {
                    array[i + 1] = array[i];
                    i--;
                }
                array[i + 1] = key;
            }
        }

        //Quicksort
        public void QuickSort(T[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(T[] array, int p, int r)
        {
            if (p < r)
            {
                int q = Particion(array, p, r);
                QuickSort(array, p, q);
                QuickSort(array, q + 1, r);
            }
        }

        private int Particion(T[] array, int p, int r)
        {
            T x = array[p];
            int i = p - 1;
            int j = r + 1;
            while (true)
            {
                for (j = j - 1; array[j].CompareTo(x) > 0; j--)
                    ;
                for (i = i + 1; array[i].CompareTo(x) < 0; i++)
                    ;
                if (i < j)
                {
                    T temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
                else
                    return j;

            }
        }

        //Merge sort
        public T[] MergeSort(T[] array)
        {
            return MSort(0, array.Length - 1, array).ToArray();
        }

        private LinkedList<T> temp;
        private LinkedList<T> MSort(int i, int j, T[]array)
        {
            if (i == j)
            {
                temp=new LinkedList<T>();
                temp.AddLast(array[i]);
                return temp;
            }
            else
            {
                int m = (i + j - 1) / 2;
                return Merge(MSort(i, m, array), MSort(m + 1, j,array));
            }
                
        }
        private LinkedList<T> Merge(LinkedList<T> L1, LinkedList<T> L2)
        {
            if (!L1.Any()) return L2;
            else if (!L2.Any()) return L1;
            else if (L1.ElementAt(0).CompareTo(L2.ElementAt(0)) <= 0)
            {
                T temp = L1.ElementAt(0);
                L1.RemoveFirst();
                L1=Merge(L1, L2);
                L1.AddFirst(temp);
                return L1;
            }
            else
            {
                T temp = L2.ElementAt(0);
                L2.RemoveFirst();
                L2 = Merge(L1, L2);
                L2.AddFirst(temp);
                return L2;
            }
        }
        //Heap Sort
        private void Heapify(T[] arr, int i, int n)
        {
            int left = 2 * i;
            int right = left + 1;
            int k = i;
            if (left <= n && arr[left].CompareTo(arr[k])>0) k = left;
            if (right <= n && arr[right].CompareTo(arr[k])>0) k = right;
            if (k != i)
            {
                T temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
                Heapify(arr, k, n);
            }
        }

        private void BuildHeap(T[] arr, int n)
        {
            for (int i = n; i >= 0; i--)
            {
                Heapify(arr, i, n);
            }
        }

        public void HeapSort(T[] arr)
        {
            int n = arr.Length - 1;
            BuildHeap(arr, n);
            for (int i = n; i >= 1; i--)
            {
                T temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, 0, i - 1);
            }
        }
    }
}

