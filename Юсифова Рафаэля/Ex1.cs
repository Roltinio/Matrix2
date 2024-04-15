
namespace Юсифова_Рафаэля
{
    /// <summary>
    /// Класс для определения равности двух цифр двузначного числа
    /// </summary>
    public class Ex1
    {
        /// <summary>
        /// Поле
        /// </summary>
        int Number;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="number"></param>
        public Ex1 (int number)
        {
            Number = number;
        }

        /// <summary>
        /// Метод сравнения двух цифр двузначного числа
        /// </summary>
        /// <returns></returns>
        public int Equals ()
        {
            int x1 = (Number / 10) % 10;
            int x2 = Number % 10;
            int result;

            if (x1 == x2)
            {
                result = 1;
            }
            else result = 0;

            return result;
        }
    }
}
