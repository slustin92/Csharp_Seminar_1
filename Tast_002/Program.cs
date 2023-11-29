// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int a = 10;
int[] randomArray = new int[a];

void array(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(0, 11);
        Console.Write(randomArray[i] + " ");
    }

}

int even(int[] randomArray)
{
    int even = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
            even++;
    }
    return even;
}

array(a); 
Console.Write($"\nКоличество чётных чисел в массиве: { even(randomArray)}");
