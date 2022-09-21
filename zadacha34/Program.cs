// Задайте массив заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве.
// Например: 345, 897, 568, 234 - 2
int[] createArray()
{
var random = new Random();

var result = new int[10];

for (long i = 0; i < result.Length; i++)
{
result[i] = random.Next(100, 1000);
}

return result;
}

int EvenNumbers(int[] array)
 {
var result = 0;

for (long i = 0; i < array.Length; i++)
{
if (array[i] %2 == 0)
result += 1;
}

return result;
}

var array = createArray();
Console.WriteLine("Сгенерирован массив:");
for(var i = 0; i < array.Length; i++)
Console.Write(array[i] + ",");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Количество четных чисел в массиве:");
Console.WriteLine(EvenNumbers(array));
Console.WriteLine();
