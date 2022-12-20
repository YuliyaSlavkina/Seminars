// Задайте двумерный массив размером m*n, заполненный случайными цифрами.

// int [,] Create2dArray(int rows, int cols, int min, int max){
// int[,] array = new int[rows, cols];
// for(int i = 0; i < rows; i++){
//     for (int j = 0; j <  cols; j++){
//         array[i,j]= new Random().Next(min,max);
//     }
//  }
//  return array;
// }

// void Show2dArray(int[,] array){
// for(int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j <  array.GetLength(1); j++){
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//  }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);



// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
//  Aₘₙ = m+n. Выведите полученный массив на экран.

// int [,] Create2dArray(int rows, int cols){
// int[,] array = new int[rows, cols];
// for(int i = 0; i < rows; i++){
//     for (int j = 0; j <  cols; j++){
//         array[i,j]= i + j;
//     }
//  }
//  return array;
// }

// void Show2dArray(int[,] array){
// for(int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j <  array.GetLength(1); j++){
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//  }
// }
// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(m, n);
// Show2dArray(array);


// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и 
// замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// int [,] Create2dArray(int rows, int cols, int min, int max){
// int[,] array = new int[rows, cols];
// for(int i = 0; i < rows; i++){
//     for (int j = 0; j <  cols; j++){
//         array[i,j]= new Random().Next(min,max);
//     }
//  }
//  return array;
// }

// void FindQuaters (int [,] array){
//    for(int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j < array.GetLength(1); j++){
//        if(i%2==0 && j%2==0){
//         array[i,j] =  array[i,j]*array[i,j];
//         Console.Write(array[i,j] + " " );
//        }
//        else 
//        Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//  } 
// }

// void Show2dArray(int[,] array){
// for(int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j <  array.GetLength(1); j++){
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//  }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);
// Console.WriteLine();
// FindQuaters(array);



// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] Create2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Dif2dArray(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                summ += array[i, j];
            }
        }
    }
    System.Console.WriteLine(summ);;
}

Console.Write("Enter numb of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(m, n, min, max);
Show2dArray(array);
System.Console.WriteLine();
Dif2dArray(array);