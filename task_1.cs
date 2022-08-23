Console.Write("Введите трёхзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}");
break;