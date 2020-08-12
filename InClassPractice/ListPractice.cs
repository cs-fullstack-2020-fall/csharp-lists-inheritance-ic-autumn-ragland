using System;
using System.Collections.Generic;

class ListPractice
{
    public void ex1()
    {
        Console.WriteLine("======================================");
        // Create a List.
        List<string> namesList = new List<string>();
        // Add four names to the List.
        namesList.Add("Bean");
        namesList.Add("Alfred");
        namesList.Add("Albert");
        namesList.Add("Deadeye");

        // Print the List one entry at a time.
        Console.WriteLine($"{namesList[0]}\n{namesList[1]}\n{namesList[2]}\n{namesList[3]}");
    }

    public void ex2()
    {
        Console.WriteLine("======================================");
        // Create an List with 5 numbers in it. Using shorthand here
        List<int> numberList = new List<int>()
        {
            2112,34,12,10,1
        };
        // Print the numbers one entry at a time.
        Console.WriteLine($"{numberList[0]}\n{numberList[1]}\n{numberList[2]}\n{numberList[3]}\n{numberList[4]}");
    }
    public void ex3()
    {
        Console.WriteLine("======================================");
        // Create an List with 4 names.
        List<string> namesList = new List<string>()
        {
            "Kevin","Autumn","Erin","Meka"
        };
        // Print the third item in the List.
        Console.WriteLine($"The third item is {namesList[2]}");

        // Delete the second item.
        namesList.RemoveAt(1);

        // Print the third item in the List again.
        Console.WriteLine($"The third item is {namesList[2]}");
    }
    public void ex4()
    {
        Console.WriteLine("======================================");
        // Create an List with any 5 numbers you choose.
        List<int> numberList = new List<int>()
        {
            2112,34,12,10,1
        };
        // Print each element in the List.
        Console.WriteLine($"{numberList[0]}\n{numberList[1]}\n{numberList[2]}\n{numberList[3]}\n{numberList[4]}");
        // Ask the user for an index.
        Console.Write("Enter the index of the element to print: ");
        int usrIndex = Int32.Parse(Console.ReadLine());
        // Print the value of the element at the provided index.
        Console.WriteLine($"The element at index position {usrIndex} is {numberList[usrIndex]}");
    }
    public void ex5()
    {
        Console.WriteLine("======================================");
        // Create an List with any 3 names you choose.
        List<string> namesList = new List<string>()
        {
            "Bob","Tim","Mark"
        };
        // Print each element in the List.
        Console.WriteLine($"{namesList[0]}\n{namesList[1]}\n{namesList[2]}");

        // Ask the user for a new name to add to the List and add it to the List.
        Console.Write("Enter a new name to add to list: ");
        namesList.Add(Console.ReadLine());
        // Print each element in the List.
        Console.WriteLine($"{namesList[0]}\n{namesList[1]}\n{namesList[2]}\n{namesList[3]}");
    }
}