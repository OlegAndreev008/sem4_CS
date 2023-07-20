// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

// double result = Math.Pow(firstNum, secondNum);
// Console.WriteLine($"число A в степени B равно {result}");
// Непонятно зачем цикл (возможно, чтобы не получать тип double, но ладно:) )

int sum = 1;
for (int i = 1; i <= secondNum; i++)
{
    sum = firstNum * sum;
}
Console.WriteLine($"число A в степени B равно {sum}");

//Создали накопительную переменную. Т.к. ищем произведение, присваиваем ей значение 1.
//Счетчик цикла начинается с 1 и умножает первое число на самого себя число раз, равное второму числу.