// Напишите задачу, которая принимает на вход число А и выдаёт сумму чисел от 1 до А

// int SummNumbers(int num){
//     int summ = 0;
//     for(int i = 1; i <= num; i++)
//         summ += i;
//     return summ;
// }
// Console.WriteLine("Enter your number");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumbers(num);
// Console.WriteLine($"summ of numbers from 1 to {num} is {summ}");



// int SummNumbers(int num){
//     int summ = 0;
//     int i = 1;
//     while(i <= num){
//         summ += i;
//         i++;
//     }
//     return summ;
// }
// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumbers(num);
// Console.WriteLine($"summ of numbers from 1 to {num} is {summ}");




// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int Counter(int num)
// {   int count = 0;
//     if (num == 0) count = 1;
//     while (num > 0)
//     {
//         num = num / 10;
//         count += 1;
//     }
//     return count;
// }

// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = Counter(num);
// Console.WriteLine($"Количество цифр в нашем числе: {count}");



// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Fact (int a){
//     int sum = 1;
//     for (int i = 1; i <= a; i++){
//         sum = sum * i;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int print = Fact(a);
// System.Console.WriteLine(print);


// Написать программу, которая выводит массив из 8ми элементов, заполненный нулями и единицами в случайном порядке

// int[] Array()
// {
//     int [] arr = new int [8];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }

//     return arr;
// }
// void ShowArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }


// ShowArray(Array());
 
//  Сделать массив размера, который укажет пользователь. Заполнить массив случайными числами от 5 до 15

int[] Array(int numb)
{
    int [] arr = new int [numb];
    for (int i = 0; i < numb; i++)
    {
        arr[i] = new Random().Next(5,16);
    }

    return arr;
}
void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(Array(size));