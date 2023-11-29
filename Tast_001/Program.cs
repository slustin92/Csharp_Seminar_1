// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

void fillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int[] array = new int[10];
fillArray(array);
PrintArray(array);

int A = 20;
int B = 90;
int count = 0;

for (int i = 0; i < 10; i++)
    if ((array[i] >= A) && (array[i] <= B)) count++;
Console.WriteLine("=> " + count);