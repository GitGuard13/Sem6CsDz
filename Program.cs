// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // 0, 7, 8, -2, -2 -> 2

// // 1, -7, 567, 89, 223-> 3



// int[] AddArray(int size)
// {
//     int[] array = new int[size];
//     for (int x = 1, i = 0; i < size; x++, i++)
//     {
//         Console.WriteLine($"Введите число № {x}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// int [] resultArray = AddArray(8);
// Console.Write($"[{String.Join(", ", resultArray)}]");

// int evenNum = 0;
// for (int i = 0;  i < resultArray.Length; i++)
//     {
//         if (resultArray[i] > 0)
//         {
            
//             evenNum++;
//         }
//         else
//         {

//         }
//     }
//     Console.WriteLine($" -> {evenNum}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите B1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите K1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите B2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите K2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);

// double y = k1 * x + b1;

// Console.WriteLine(" ");
// Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x};{y})");