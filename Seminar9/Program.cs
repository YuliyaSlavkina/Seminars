// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N

// void ShowNumbers(int N){    
//     if (N>1)  ShowNumbers(N-1);
//     Console.Write(N + " ");
// }
// Console.Write("Enter your number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(N);

// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутки 
// от M до N

// void ShowNumbersMN (int n, int m){

// if (Math.Max(n,m) != Math.Min(n,m)) 
//     ShowNumbersMN( Math.Min(n,m), Math.Max(n,m)-1);
// Console.Write($"{Math.Max(n,m)} ");
// }

// ShowNumbersMN(8,4);


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SumNumbers (int numb){
//     if(numb < 0)
//      numb*=-1;
//     if(numb > 0)
//      return SumNumbers(numb/10) + numb % 10;
//     else
//      return 0;
// }
// Console.Write("Enter your number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int sum = SumNumbers(numb);
// Console.Write(sum);


// Напишите программу, которая на вход принимает два числа A и B, и возводит число А 
// в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

double Power (int a, int b){
    if ( b < 0)
        return Power(a, b+1)/a;
    if(b > 0)
        return Power(a,b-1)*a;
    return 1.0;    
}

Console.Write("Enter your first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your second number: ");
int b = Convert.ToInt32(Console.ReadLine());
double power = Power(a,b);
Console.Write(power);
