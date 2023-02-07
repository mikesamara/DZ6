//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
System.Console.WriteLine("Веедите числа");
string str = Console.ReadLine();
string [] arr = str.Split();
long [] array = new long[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    array[i] = Convert.ToInt32(arr[i]);
}
long count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}   
System.Console.WriteLine($"Количетсво значений больше 0 = {count}");