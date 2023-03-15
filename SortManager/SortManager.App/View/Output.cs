using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager.App.View
{
    internal class Output
    {
        public void StartUpMessage()
        {
            Console.WriteLine("Welcome to out Sort Manager");
            Console.WriteLine("Please Choose from the following sort Methods to sort an unsorted array: \n1: BubbleSort, \n2: HeapSort, \n3: MergeSort \n4: .NET LibrarySort");

            string input = Console.ReadLine().ToLower();

            HandleUserInput(input);
        }

        public void HandleUserInput(string userInput)
        {
            switch(userInput)
            {
                case "1":
                    //Do BubbleSort
                    break;
                case "2":
                    //Do HeapSort
                    break;
                case "3":
                    //Do MergeSort
                    break;
                case "4":
                    //Do .NET LibrarySort
                    break;
                default:
                    Console.WriteLine($"Incorrect value given: {userInput}");
                    break;
            }
        }


    }
}
