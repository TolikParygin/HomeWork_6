// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.Clear();


int[] EntaringArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}-й элемент массива  ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

System.Console.Write("Введите колличество элементов массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = EntaringArray(number);
int positiveNumber = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveNumber++;
    }
}
Console.Write('[' + string.Join(", ", array) + ']');
System.Console.WriteLine("  -> " + positiveNumber);
