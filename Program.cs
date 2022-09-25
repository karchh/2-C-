/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 18

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра этого трехзначного числа есть ни что иное, как "+stringNumber[1]);


Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6


Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра - " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> Третьей цифры нет");
}

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введи цифру, обозначающую день недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int DayNumber) {
  if (DayNumber == 7 || DayNumber == 7) {
  Console.WriteLine("(Этот день выходной) - Да");
  }
  else if (DayNumber < 1 || DayNumber > 7) {
    Console.WriteLine("Это вашпэ не день недели!");
  }
  else Console.WriteLine("(Этот день не выходной) - Нет, ты же работаешь по шестидневке, забыл штоле?");
}
CheckingTheDayOfTheWeek(DayNumber);
