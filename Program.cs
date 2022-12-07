// Задание 1
// void palindrom(){
//         Console.Write("Введите пятизначное число: ");
//         int number = Convert.ToInt32(Console.ReadLine()); 
//         int num1 = number / 10000 % 10;
//         int num2 = number / 1000 % 10;
//         int rev1 = number / 10 % 10;
//         int rev2 = number % 10;
//         int nul = number / 10000;
        
//             if (nul < 1 || nul > 9){
//             Console.WriteLine(number + " -> " + "Не пятизначное число.");
//             }
//             else if  (num1 == rev2 && num2 == rev1){
//             Console.WriteLine(number + " -> Это палиндром");
//             }
//             else{
//             Console.WriteLine(number + " -> Не палиндром");
//             }
//         }
//         for (int i = 0; i < 10; i++)
//         { 
            
//     }
// palindrom();





// Задание 2
// double Geo(int x1, int x2, int y1, int y2, int z1, int z2){
//     double f= (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1);
//     double g= Math.Sqrt(f);
//     return(g);
// }
// Console.WriteLine("Введите координату x1: ");
// int x1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x2: ");
// int x2= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1: ");
// int y1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2: ");
// int y2= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z1: ");
// int z1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z2: ");
// int z2= Convert.ToInt32(Console.ReadLine());
// double res = Geo(x1, x2, y1, y2, z1, z2);
// Console.WriteLine($"Результат : {Math.Round(res,2)}");




// Задание 3
// void Table (int num)
// {
// int num1 = 1;
//     while (num1 <= num)
//     {
//         Console.Write(num1 * num1* num1 + " ");
//         num1++;
//     }
// }
// Console.WriteLine("Please, write number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Table(number);























// void SearchSquad(int x, int y){
//     if(x==0 || y==0)
//     Console.WriteLine("Error");
//     else if (x>0 && y>0)
//     Console.WriteLine("Точка находится в первой четверти");
//     else if (x>0 && y<0)
//     Console.WriteLine("Точка находится в четвертой четверти");
//     else if (x<0 && y>0)
//     Console.WriteLine("Точка находится во второй четверти");
//     else 
//     Console.WriteLine("Точка находится в третьей четверти");
// }

// Console.Write("Введите координату x: ");
// int x= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y: ");
// int y= Convert.ToInt32(Console.ReadLine());

// SearchSquad(x, y);



// void SearchCoordinate(int quater){
//     if (quater ==1)
//         Console.WriteLine("x>0 and y>0");
//     else if (quater ==2)
//         Console.WriteLine("x<0 and y>0");
//     else if (quater ==3)
//         Console.WriteLine("x<0 and y<0");
//     else if (quater ==4)
//         Console.WriteLine("x>0 and y<0");
//     else Console.WriteLine("Error");
// }
// Console.WriteLine("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// SearchCoordinate(num);



//      Напишите программу, которая принимает на вход число
//      (N) и выдаёт таблицу квадратов чисел от 1 до N
// void Table (int num)
// {
// int num1 = 1;
//     while (num1 <= num)
//     {
//         Console.Write(num1 * num1 + " ");
//         num1++;
//     }
// }
// Console.WriteLine("Please, write number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Table(number);

//          Через цикл for!
// void Table (int num)
// {
//     for (int num1 = 1; num1 <= num; num1++)
//     {
//         Console.Write(num1 * num1 + " ");
//     }
// }
// Console.WriteLine("Please, write number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Table(number);



// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними 
// в 2D пространстве.


// double Geo(int x1, int x2, int y1, int y2){
//     double f= (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
//     double g= Math.Sqrt(f);
//     return(g);
// }
// Console.WriteLine("Введите координату x1: ");
// int x1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x2: ");
// int x2= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1: ");
// int y1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2: ");
// int y2= Convert.ToInt32(Console.ReadLine());
// double res = Geo(x1, x2, y1, y2);
// Console.WriteLine($"Результат : {Math.Round(res,2)}");