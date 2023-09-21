// See https://aka.ms/new-console-template for more information
using Testing.Sorting;

Console.WriteLine("Hello, World!");


Console.WriteLine(string.Join(", ", SelectionSortTest.Run(new List<int> {2, 8, 5, 3, 9, 4, 1})));
Console.WriteLine(string.Join(", ", InsertionSortTest.Run(new List<int> {2, 8, 5, 3, 9, 4, 1})));