﻿// //Напишите программу, которая выводит третью цифру заданного числа 
// //или сообщает, что третьей цифры нет.

// //Считываем число
// Console.Write("Введите трёх или более значное число: ");
// string num = Console.ReadLine();
// // Превращаем его в массив
// char[] arr = num.ToCharArray();
// //Выводим третью цифру числа.
// Console.WriteLine("Третья цифра числа: " + arr[2]);

//Задача со * Сделать вариант для числа длиной до 10 цифр не используя char или string
//Сначала делаем 8ми значное число
//Принимаем рандомное число до 8 знаков
Console.WriteLine();
System.Random numSintez = new System.Random();
int rndNumber = numSintez.Next(100000000);
Console.WriteLine("Получаем рандомное число: " + rndNumber);

//Очень примитивное решение.
//Запускаю циклпри котором в каждом витке будет отсекаться 
//последнее число, до момента становления его трёхзначным.
// while (rndNumber > 999)
// {
//       rndNumber = rndNumber / 10;
// }
// После чего проверяем число, если трёхзначное, выводим остаток.
// Если двузначное, указываем ошибку.
if (rndNumber > 99)
{
      while (rndNumber > 999)
      {
            rndNumber = rndNumber / 10;
      }
      Console.WriteLine(rndNumber % 10);
}
else
{
      Console.WriteLine("Это двузначное число...");
}

//А потом с 64 разрядным я не вытянул.....
