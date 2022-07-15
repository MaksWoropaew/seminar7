//1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

//2. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1 + 9 + 2 = 12


namespace Classwork
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите сколько будет строк: ");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько будет столбцов: ");
            int stol = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[str, stol];
        }
        public static void SumEl(int[,] array)
        {
            int result = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        result = result + array[i, j];
                    }
                }
            }
        }
        public static void GenMass(int[,] array, int str, int stol)
        {
            for (int i = 0; i < str; i++)
            {

            }

        }
        //public static void FillArray
    }
}

