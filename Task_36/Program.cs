// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[new Random().Next(5, 16)];
int sum = 0;
var newRnd = new Random();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    array[i] = newRnd.Next(0, 1000);
    Console.Write(array[i] + ", ");

    if(i % 2 != 0)
    {
        sum = sum + array[i];
    }

}

Console.WriteLine("]");
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {sum}.");
