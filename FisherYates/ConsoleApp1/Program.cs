// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Algorithem.Shuffle(array);
Console.WriteLine("SHUFFLE: {0}", string.Join(",", array));

string[] array2 = { "bird", "frog", "cat" };
Algorithem.Shuffle(array2);
Console.WriteLine("SHUFFLE: {0}", string.Join(",", array2));