// Задача 69.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int A, int B)
{
    if (B == 0) return 1;
    return A * Pow(A, B - 1);    
    
}

int A = ReadInt("Введите число: ");
int B = ReadInt("Введите степень числа: ");
System.Console.WriteLine(Pow(A, B));