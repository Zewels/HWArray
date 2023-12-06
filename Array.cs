//Задача 1
//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат 
//в отрезке [20,90].

int [] CreateArray (int min, int max, int size) //Создание массива
{
    int [] array = new int [size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void ShowArray(int [] array) //Вывод массива
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void CountArray(int [] array) //Счетчик
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]>=20)
        {
            if(array[i]<=90)
            {
                count++;
            }
        }
    }
    Console.WriteLine(count);
}

Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);
ShowArray(array);
CountArray(array);

//Задача 2
//Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет количество чётных чисел в массиве.

int [] CreateArray (int min, int max, int size) //Создание массива
{
    int [] array = new int [size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void ShowArray(int [] array) //Вывод массива
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void CountArray(int [] array) //Счетчик
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i] % 2 ==0)
        {
            
            count++;
            
        }
    }
    Console.WriteLine(count);
}

Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);
ShowArray(array);
CountArray(array);

//Задача 3
//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateArray (int min, int max, int size) //Создание массива
{
    double [] array = new double [size];
        for(int i = 0; i<size; i++)
    {
       array[i] = new Random().Next(min,max+1) + new Random().NextDouble();
    }
    return array;
}

void ShowArray(double [] array) //Вывод массива
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void CountArray(double [] array) //Счетчик
{
    double count = 0;
    double zero = array[0]; //Минимальное число
    double one = array[0]; //Максимальное число
    for(int i = 0; i<array.Length; i++)
    {
        if (zero>array[i])
        {
            
            zero = array[i];
            
        }
        if (one<array[i])
        {
            one = array[i];
        }
    }
    count = one - zero;
    Console.WriteLine(count);
}

Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

double [] array = CreateArray(min, max, size);
ShowArray(array);
CountArray(array);