// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов стоящих на нечетных позициях.
// Например: 3, 7, 23, 12 - 19;   -4, -6, 89, 6 - 0.
int[] createArray()
{
var random = new Random();

var result = new int[5];

for (long i = 0; i < result.Length; i++)
{
result[i] = random.Next(1, 100);
}

return result;
}

int SumNumbersOddPosition(int[] array)
 {
var result = 0;

for (long i = 0; i < array.Length; i++)
{
if (i %2 != 0)
result += array[i];
}

return result;
}

var array = createArray();
Console.WriteLine("Сгенерирован массив:");
for(var i = 0; i < array.Length; i++)
Console.Write(array[i] + ",");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Сумма элементов стоящих на нечетных позициях:");
Console.WriteLine(SumNumbersOddPosition(array));
Console.WriteLine();

