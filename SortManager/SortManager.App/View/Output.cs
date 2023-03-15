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
        int[] unsortedArray = HandleInput.GetRandomArray(lengthInput);

        Console.WriteLine("Please choose from the following sort Methods to sort an unsorted array: \n1: BubbleSort, \n2: HeapSort, \n3: MergeSort \n4: .NET LibrarySort");
        string input = Console.ReadLine().ToLower();

        if (input == "quit") Environment.Exit(0);
        HandleInput.HandleUserInput(input, unsortedArray);
    }
}
