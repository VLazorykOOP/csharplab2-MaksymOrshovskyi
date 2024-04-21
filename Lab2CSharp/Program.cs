using System;

class Program
{
    static void Main()
    {
        // Заданий масив
        int[] array = { 1, 5, 7, 9, 12, 15, 18, 20 };

        // Введення границь інтервалу від користувача
        Console.WriteLine("Введіть початкову границю інтервалу:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кінцеву границю інтервалу:");
        int end = int.Parse(Console.ReadLine());

        // Заміна елементів масиву, що потрапляють в інтервал, нулем
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= start && array[i] <= end)
            {
                array[i] = 0;
            }
        }

        // Виведення зміненого масиву
        Console.WriteLine("Масив після заміни:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
