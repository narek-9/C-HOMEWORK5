// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

var array = new double[new Random().Next(4, 9)];
var newRnd = new Random();

Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    array[i] = newRnd.Next(0, 100);
    Console.Write(array[i] + ", ");
}

double max = array[0];
double min = array[0]; 

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max) max = array[i];
}

for (int i = 0; i < array.Length; i++)
{
    if(array[i] < min) min = array[i];
}
double result = max - min;

Console.WriteLine("]");
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine(result);
