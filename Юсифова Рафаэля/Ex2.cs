using System;

namespace Юсифова_Рафаэля
{
    public class Ex2
    {
        //Поля
        int NumberOne;
        int NumberTwo;
        int NumberThree;

        //Конструктор
        public Ex2 (int numberOne, int numberTwo, int numberThree)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
            NumberThree = numberThree;
        }

        /// <summary>
        /// Возведение в квадрать положительных чисел
        /// </summary>
        /// <param name="NumberOne"></param>
        /// <param name="NumberTwo"></param>
        /// <param name="NumberThree"></param>
        /// <param name="ResultOne"></param>
        /// <param name="ResultTwo"></param>
        /// <param name="ResultThree"></param>
        public static void SquareNumber (int NumberOne, int NumberTwo, int NumberThree, out int ResultOne, out int ResultTwo, out int ResultThree)
        {
            if (NumberOne>=0)
            {
                ResultOne = (int)Math.Pow(NumberOne, 2);
            }
            else 
                ResultOne = NumberOne;

            if (NumberTwo>=0)
            {
                ResultTwo = (int)Math.Pow(NumberTwo, 2);
            }
            else 
                ResultTwo = NumberTwo;

            if (NumberThree>=0)
            {
                ResultThree = (int)Math.Pow(NumberThree, 2);
            }
            else
                ResultThree = NumberThree;

        }
    }
}
