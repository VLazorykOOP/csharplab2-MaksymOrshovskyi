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

        Console.WriteLine();
//_____________________________________________________________________
        // Введення розміру масиву
        Console.WriteLine("Введіть розмір масиву:");
        int n = int.Parse(Console.ReadLine());

        // Ініціалізація масиву з введеним розміром
        double[] array2 = new double[n];

        // Зчитування елементів масиву з клавіатури
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введіть {0}-й елемент масиву:", i + 1);
            array2[i] = double.Parse(Console.ReadLine());
        }

        // Знаходження максимального значення в масиві
        double max = array2[0];
        for (int i = 1; i < n; i++)
        {
            if (array2[i] > max)
            {
                max = array2[i];
            }
        }

        // Заміна всіх максимальних елементів нулями
        for (int i = 0; i < n; i++)
        {
            if (array2[i] == max)
            {
                array2[i] = 0;
            }
        }

        // Виведення зміненого масиву
        Console.WriteLine("Масив після заміни:");
        foreach (var item in array2)
        {
            Console.Write(item + " ");
        }
    }
}
