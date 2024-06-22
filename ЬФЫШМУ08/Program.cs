using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЬФЫШМУ08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int UserInput;
            int shift;
            int tempNumber = 0;
            Console.WriteLine("дан массив чисел: ");
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine("\nНасколько позиций сдвинуть массив влево? Введите число: ");
            UserInput = Convert.ToInt32(Console.ReadLine());

            shift = UserInput % array.Length;

            for (int i = 0; i < shift; i++)
            {
                Console.Write("Получченый массив: ");

                tempNumber = array[0];
            }

            for (int j = 0; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];

                Console.Write(array[j] + " ");
            }
            array[array.Length - 1] = tempNumber;

            Console.Write(array[array.Length - 1]);
            Console.ReadKey();  
        }
    }
}
