// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.

// int[] CreateArray(int size, int minValue, int maxValue){
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
        
//     }


// int FindPosSumm(int[]array){
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >0)
//             summ+= array[i];
//     }
//     return summ;
// }

// int FindNegSumm(int[]array){
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             summ+= array[i];
//     }
//     return summ;
// }

// int size = 12;
// int min = -9;
// int max = 9;
// int[] array = CreateArray(size, min, max);
// ShowArray(array);
// Console.WriteLine($"Summ of positive number is {FindPosSumm(array)}");
// Console.WriteLine($"Summ of negative number is {FindNegSumm(array)}");

// // 1. Напишите программу замены элементов массива: положительные элементы замените на
// //  соответствующие отрицательные, и наоборот.
 
// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void Obmen(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i] * (-1)} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ВВедите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ВВедите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size, min, max);
// Obmen(array);
// ShowArray(array);


// 2. Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] Massiv(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

bool FindNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
       
        return true;
    }
    return false;
}

int size = 20;
int min = 0;
int max = 9;
int num = 4;


int[] nums = Massiv(size, min, max);
ShowArray(nums);
bool flag = FindNumber(nums, num);
if(flag==true) Console.Write("Yes");
else Console.Write("No");