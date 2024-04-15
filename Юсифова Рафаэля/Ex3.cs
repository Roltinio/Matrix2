using System;
using System.Data;

namespace Юсифова_Рафаэля
{
    static public class Ex3
    {
        /// <summary>
        /// Заполнение массива с указаным отрезком от -10 до 10
        /// </summary>
        /// <param name="array"></param>
        /// <param name="count"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        static public void Fill(this Array<int> array, int count, int min = -10, int max = 10)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                array.Add(rnd.Next(min, max));
            }
        }

        /// <summary>
        /// Создание массива в табличном элементе DataTable
        /// </summary>
        /// <param name="array">целочисленный массив</param>
        /// <returns>массив</returns>
        public static DataTable DTOneDimArray(this Array<int> array)
        {
            var result = new DataTable();
            for (int i = 0; i < array.Length; i++)
            {
                result.Columns.Add("col" + (i + 1), typeof(int));
            }

            var row = result.NewRow();
            for (int i = 0; i < array.Length; i++)
            {
                row[i] = array[i];
            }

            result.Rows.Add(row);
            return result;
        }

        /// <summary>
        /// Нахождение кол-во отрицательныъ элементов
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static public int NegativeCount(this Array<int> array)
        {
            double[] result = new double[array.Length];
            int count = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Нахождение произведения элементов их отрезка
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static public double[] Multiplay(this Array<int> array)
        {

            double[] result = new double[array.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Math.Pow(array[i], 2);
            }
            return result;
        }
    }


}
