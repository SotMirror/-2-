/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Введите число");
string number = Console.ReadLine();
int SecondNumber = Convert.ToInt32(number);
if (SecondNumber > 99 )
{

    Console.WriteLine(number[2]);

}
else 
{

    Console.WriteLine("Третьей цифры нет");

}
