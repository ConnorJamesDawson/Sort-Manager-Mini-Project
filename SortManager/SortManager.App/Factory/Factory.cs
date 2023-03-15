using SortManager.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager.App.Factory
{
    public static class Factory
    {
        public static AbstractSort CreateSortAlgorithm(string algorithmType)
        {
            algorithmType = algorithmType.ToLower();

            switch(algorithmType) 
            {
                case "bubblesort":
                    return new BubbleSort();
                case "heapsort":
                    return new HeapSort();
                case "mergesort":
                     return new MergeSort();
                case "radixsort":
                    //return new RadixSort();
                default:
                    throw new ArgumentException("Could not instantiate that type of sorting algorithm");
            }
        }
    }
}
