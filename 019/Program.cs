/* Задача 19

Напишите программу, 
которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да 
*/

Console.WriteLine("Введите пятизначное число");

int num = Convert.ToInt32(Console.ReadLine());
int a = Math.Abs(num);
string strNum = Convert.ToString(a);

if (strNum.Length == 5)
{
    if (strNum[0] == strNum[4] & strNum[1] == strNum[3])
    {
        Console.WriteLine("Ваше число является полиндромом");
    }
    else 
    {
        Console.WriteLine("Ваше число не является полиндромом");
    }

}

else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}