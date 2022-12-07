//Console.Write("Сколько вам лет: ");
//int test = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Через 6 лет вам будет  "+(test+6+ "лет"));


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Квадрат числа {number} это {number*number}");


//         if (username.ToLower() == "маша")
//         {
//             Console.WriteLine("Ура, это же МАША");
//         }
//         else
//         {
//             Console.Write("Привет, ");
//             Console.WriteLine(username);


// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if (numberA == numberB*numberB)
// {
//     Console.WriteLine("Ура, вы угадали");
// }
// else 
// {
//     Console.WriteLine("Попробуйте еще раз");
// }


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("ПН");
// }

// else if (number == 2)
// {
//     Console.WriteLine("ВТ");
// }

// else if (number == 3)
// {
//     Console.WriteLine("СР");
// }

// else if (number == 4)
// {
//     Console.WriteLine("ЧТ");
// }

// else if (number == 5)
// {
//     Console.WriteLine("ПТ");
// }

// else if (number == 6)
// {
//     Console.WriteLine("СБ");
// }

// else if (number == 7)
// {
//     Console.WriteLine("ВС");
// }
// else 
// Console.WriteLine ("Error");


Console.Write("Enter your number: ");
int numb = Convert.ToInt32(Console.ReadLine());
int numb1 = numb*(-1);
while (numb1 <= numb)
{   
    Console.Write(numb1+" ");

    numb1++;
}

Console.Write("Enter your трехзначное number: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb>99 && numb<1000)
{
    int numb1= numb%10;
    Console.WriteLine(numb1);
}
else 
    Console.Write ("Число не трехзначное");