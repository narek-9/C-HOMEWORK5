// // Задайте массив заполненный случайными
// // положительными трёхзначными числами. Напишите
// // программу, которая покажет количество чётных чисел в
// // массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[new Random().Next(3, 10)];
int count = 0;
var newRnd = new Random();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    array[i] = newRnd.Next(100, 1000);
    Console.Write(array[i] + ", ");
    
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine("]");

Console.WriteLine($"Кол-во четных чисел = {count}");

