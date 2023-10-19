////стр 33 №3
//Console.Write("Введите натуральное число ");
//int n = int.Parse(Console.ReadLine());
//double proiz = 1.0;
//for (double k = 1.0; k <= n; k++)
//{
//    double P = (2 * k) / (2 * k + 1);
//    proiz *= P;
//}
//Console.WriteLine($"Произведение первых сомножителей:{proiz}");

//стр 41 №1
//int z;
//int y;
//int x = 0;
//int g;
//int sum;
//Console.WriteLine("Введите натуральное число ");
//z = Convert.ToInt32(Console.ReadLine());
//g = z;
//while (z != 0)
//{
//    if (z / 10 == 0)
//        x = z;
//    z /= 10;
//}
//y = g % 10;
//sum = x + y;
//Console.WriteLine($"Cумма первого и последнего числа равны = {sum}");

////стр 43 №1
//Console.Write("Введите натуральное число ");
//int n = int.Parse(Console.ReadLine());
//int x = 0;
//int y = n % 10;
//while (n > 0)
//{
//    x = n % 10;
//    n /= 10;
//    if (n < 10)
//        break;
//}
//int sum = y + x;
//Console.WriteLine($"Сумма первой и последней цифры числа: {sum}");