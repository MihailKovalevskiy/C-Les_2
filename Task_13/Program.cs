//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
char[] array = Console.ReadLine().ToCharArray();
var arrayValue = string.Join("", array);
if (array.Length <= 2) 
{
    Console.WriteLine("Третьей цифры нет!");
} 
else 
    Console.WriteLine($"Третья цифра числа = {array[2]}");
