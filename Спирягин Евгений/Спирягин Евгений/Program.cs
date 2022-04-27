using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Спирягин_Евгений
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашная работа");
            Console.WriteLine("Выполнил: Спирягин Евгений");
            Console.WriteLine("Задание №17"); 
            Random random = new Random();
            Console.Write("Введите количество элементов в списке: N=");
            int N = int.Parse(Console.ReadLine());
            List<int> listNumbers = new List<int>(N);
            for (int i = 0; i < N; i++) listNumbers.Add(random.Next(-100, 100));
            Console.Write("Список: ");
            PrintList(listNumbers);
            int IndMin = 0;
            if (listNumbers.Count > 0)
            {
                IndMin = listNumbers.LastIndexOf(listNumbers.Min());
                Console.WriteLine($"Минимальный элемент: {listNumbers.Min()}, с индексом: {IndMin}.");
            }
            int IndMax = 0;
            if (listNumbers.Count > 0)
            {
                IndMax = listNumbers.LastIndexOf(listNumbers.Max());
                Console.WriteLine($"Максимальный элемент: {listNumbers.Max()}, с индексом: {IndMax}.");
            }
            if (IndMin < IndMax)
            {
                List<int> listSum = listNumbers.GetRange(IndMin + 1, IndMax - IndMin - 1);
                Console.Write("Элементы для суммирования: ");
                PrintList(listSum);
                Console.WriteLine($"Сумма: {listSum.Sum()}");
            }
            else Console.WriteLine("Суммирование не произведено, т.к. минимальный элемент не предшествует максимальному!");


            Console.WriteLine("Задание №19"); 
            Console.Write("Введите количество элементов в списке: N=");
            int N2 = int.Parse(Console.ReadLine());
            List<int> listNaturalNumbers = new List<int>(N2);
            for (int i = 0; i < N2; i++) listNaturalNumbers.Add(random.Next(10));
            Console.Write("Список: ");
            PrintList(listNaturalNumbers);
            Console.Write("Задайте значение (кратные ему элементы будут удалены): k=");
            int k = int.Parse(Console.ReadLine());
            Console.Write($"Элементы кратные {k}: ");
            PrintList(listNaturalNumbers.Where(x => x % k == 0 && x != 0).ToList());
            Console.Write($"Список с удалёнными элементами, кратные {k}: ");
            PrintList(listNaturalNumbers.Where(x => x % k != 0 || x == 0).ToList());


            Console.WriteLine("Задание №22"); 
            Console.Write("Введите количество элементов в списке: N=");
            int N3 = int.Parse(Console.ReadLine());
            List<int> listIntegers = new List<int>(N3);
            for (int i = 0; i < N3; i++) listIntegers.Add(random.Next(-50, 50));
            Console.WriteLine("Список: ");
            PrintList(listIntegers);
            Console.Write("Количество различных элементов: ");
            HashSet<int> countUniqueElements = new HashSet<int>(listIntegers);
            Console.WriteLine(countUniqueElements.Count);
            Console.ReadKey();
        }
        private static void PrintList(List<int> list)
        {
            if (list.Count > 0)
            {
                string numbers = "";
                foreach (int number in list)
                {
                    numbers += $"{number}, ";
                }
                Console.WriteLine(numbers.Remove(numbers.Length - 2, 2));
            }
            else
            {
                Console.WriteLine("Пусто");
            }
        }
    }
}
