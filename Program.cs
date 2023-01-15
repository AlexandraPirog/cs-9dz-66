/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.Clear();
int n = InputNumber("Введите число N: ");
int m = InputNumber("Введите число M: ");
System.Console.WriteLine(SumNumberRec(n,m));

int SumNumberRec(int n, int m)
{
    if (n <= m)
    {
        return n + SumNumberRec(n + 1, m);
    }
    else
    {
        return 0;
    }
}

//Проверка на число
int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");

    }
    return number;
}
