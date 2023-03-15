using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using SortManager.App.Controller;
using SortManager.App.Model;

namespace SortManager.App.View;

public class Output
{
    public static void StartUpMessage()
    {
        Console.WriteLine("Welcome to out Sort Manager");

        Console.WriteLine("Please choose a length of your array: ");
        int lengthInput = Int32.Parse(Console.ReadLine());
        HandleInput.GetRandomArray(lengthInput);

        Console.WriteLine("Please choose from the following sort Methods to sort an unsorted array: \n1: BubbleSort, \n2: HeapSort, \n3: MergeSort \n4: .NET LibrarySort");
        string input = Console.ReadLine().ToLower();

        HandleUserInput(input);
    }

    public static void HandleUserInput(string userInput)
    {
        switch(userInput)
        {
            case "1":
                //new BubbleSort();
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
