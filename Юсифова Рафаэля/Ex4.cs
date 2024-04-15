using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Юсифова_Рафаэля
{
    public static class Ex4
    {
        public static void SwapMaxMin(int[,] matrix)
        {
            int min = int.MaxValue,
                max = int.MinValue,
                iMin = 0,
                jMin = 0,
                iMax = 0,
                jMax = 0,

                value;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        iMax = i;
                        jMax = j;
                    }

                    if (matrix[i, j]<min)
                    {
                        min = matrix[i, j];
                        iMin = i;
                        jMin = j;
                    }
                }
            }

            value = matrix[iMax, jMax];
            matrix[iMax, jMax] = matrix[iMin, jMin];
            matrix[iMin, jMin] = value;
        }
    }
}
