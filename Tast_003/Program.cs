// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.


int a = 5;
double[] array = new double[5];

void mas(int a)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    }

    System.Console.Write(string.Join(" ", array));

}

double raz(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 0;
    while (i < array.Length)
    {

        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
        i++;
    }
    return Math.Round(max - min, 2);
}

mas(a);
Console.Write($"\nРазницу между максимальным и минимальным элементов массива: {raz(array)}");