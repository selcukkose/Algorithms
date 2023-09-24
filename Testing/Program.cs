// See https://aka.ms/new-console-template for more information
using Testing.Sorting;

Console.WriteLine("Hello, World!");


string.Join(", ", SelectionSortTest.Run(new List<int> {2, 8, 5, 3, 9, 4, 1, 36, 45, 85, 78, 96, 12, 31, 42, 14, 55, 66, 32, 44, 75, 32, 31, 83}));
string.Join(", ", InsertionSortTest.Run(new List<int> {2, 8, 5, 3, 9, 4, 1, 36, 45, 85, 78, 96, 12, 31, 42, 14, 55, 66, 32, 44, 75, 32, 31, 83}));
string.Join(", ", BubleSortTest.Run(new List<int> {2, 8, 5, 3, 9, 4, 1, 36, 45, 85, 78, 96, 12, 31, 42, 14, 55, 66, 32, 44, 75, 32, 31, 83}));
