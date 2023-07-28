/* Task 1
int Polin (string mess)
{
    Console.Write(mess);
    string chis = Console.ReadLine();
    int result = Convert.ToInt32(chis);
    return result;
}
int degree(int num, int level)
{
    int number = 1;
    for (int i = 0; i < level; i++)
    {
        number *= num;
    }
    return number;
}
int num = Polin("Введите первое число: ");
int level = Polin("Введите второе число: ");
if (level < 0)
{
    Console.WriteLine("Степень не может быть меньше 0");
}
else 
{
    Console.WriteLine($"Число {num} в степени {level} равно {degree(num, level)}");
}
*/

/* Task 2

int Polin (string mess)
{
    Console.Write(mess);
    string chis = Console.ReadLine();
    int result = Convert.ToInt32(chis);
    return result;
}
int Amount(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}
int num = Polin("Введите число: ");
Console.WriteLine($"Сумма всех чисел в цифре = {Amount(num)}");
*/

/* Task 3

int Polin (string mess)
{
    Console.Write(mess);
    string chis = Console.ReadLine();
    int result = Convert.ToInt32(chis);
    return result;
}
int[] Generate(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void Print(int[] array)  
{
    Console.Write("[");
    for (int i =0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
int size = Polin("Длина массива: ");
int min = Polin("Начало: ");
int max = Polin("Конец: ");
int[] array = Generate(size, min, max);
Print(array);
*/