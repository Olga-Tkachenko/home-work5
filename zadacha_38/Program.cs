// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементом массива. Например: 3, 7, 22, 2, 78 - 76  
double[] createArray()
{
    var random = new Random();
    double[] result = new double[5];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round(random.NextDouble() * (10-1)+1, 2);
    }
    return result;
}

double MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}

var array = createArray();
Console.WriteLine("Сгенерирован массив:");
for(var i = 0; i < array.Length; i++)
Console.Write(array[i] + ";");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Разница между максимальным и минимальным элементами массива = ");
Console.WriteLine(MaxMin(array));
Console.WriteLine();
