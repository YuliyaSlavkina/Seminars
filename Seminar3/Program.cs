// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


// void SearchSquad(int x, int y){
//     if ( x == 0 || y == 0)
//         Console.WriteLine("Error");
//     else if (x > 0 && y >0)
//         Console.WriteLine("Точка находится в первой четверти");
//     else if (x > 0 && y < 0)
//         Console.WriteLine("Точка находится в четвертой четверти");
//     else if (x < 0 && y >0)
//         Console.WriteLine("Точка находится в второй четверти");
//     else 
//         Console.WriteLine("Точка находится в третьей четверти");
// }

// Console.Write("Введите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// SearchSquad(x, y);

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// void SearchCoordinates(int quater){
//     if (quater == 1)
//     {
//         Console.WriteLine("x > 0 y > 0");
//     }
//     else if (quater == 2)
//     Console.WriteLine("x > 0 y < 0");
//     else if (quater == 3)
//         Console.WriteLine("x < 0 y < 0");
//     else if (quater == 4)
//         Console.WriteLine("x > 0 y < 0");
//     else
//         Console.WriteLine("Error");
// }
// Console.WriteLine("Введите четверть");
// int number  = Convert.ToInt32(Console.ReadLine());
// SearchCoordinates(number);

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N


// Console.WriteLine("Введите число");
//  int number  = Convert.ToInt32(Console.ReadLine());

//  void Table(int num){
//     for (int i = 0; i <=num; i++){
//         int count = i*i;
//         Console.Write(count + " ");
//     }
//  }

//  Table(number);

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


    


void Distance(int X1, int Y1, int X2, int Y2) {
    double num = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1));
    Console.WriteLine("Расстояние =" + num);
}

Console.WriteLine("Введите координату X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());

Distance(X1, Y1, X2, Y2);

    
