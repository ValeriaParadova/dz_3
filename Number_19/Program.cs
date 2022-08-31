// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// Например:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter number: ");
string number = Console.ReadLine();

void Palindrom(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - не является палиндромом.");
}

if (number!.Length == 5){
  Palindrom(number);
}
else Console.WriteLine($"Ошибка ввода, введите правильное число");
