// void Test(int a, int b){
//     if (a > b){
//         Console.WriteLine($"{a} больше {b}");
//     }
//     else
//     {
//         Console.WriteLine($"{b} больше {a}");
//     }
// }

// int num1 = 4;
// int num2 = 5;
// Test(num1, num2);


// int Test (int a, int b){
//     if (a > b)
//         return a;
//     else 
//         return b;
//     return 0;
// }

// int num1 = 5;
// int num2 = 4;
// int result = Test(num1, num2);
// Console.WriteLine("Результат " + result);

// int Line(){
//     int num = new Random().Next(10, 100);
//     Console.WriteLine("Ваше число - " + num);
//     int dec = num / 10;
//     int ed = num%10;
//     if (dec > ed)
//         return dec;
//     else if (dec == ed)
//         return ed;
//     else
//         return ed;
// }

// int res = Line();
// Console.WriteLine("Большее число - " + res);


// int Line (){
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine("Ваше число - " + num);
//     int hund = num / 100;
//     int ed = num / 100 % 10;
//     int one = num % 10;
//     return ((hund*10)+ one);
// }
// int res = Line();
// Console.WriteLine("Большее число - " + res);

int SecondNumber() {
    Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int dec = num / 10;
    return dec % 10; 
}

int result = SecondNumber();
Console.WriteLine (result);