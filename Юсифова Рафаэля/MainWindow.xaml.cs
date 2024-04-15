using System;
using System.Configuration;
using System.Data.Common;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Linq;

namespace Юсифова_Рафаэля
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItEx1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ввести двузначное число. Определить: одинаковы ли его цифры",
               "Задание 1",
               MessageBoxButton.OK,
               MessageBoxImage.Asterisk);
        }

        private void mItEx2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ввести три целых числа. Возвести в " +
                "квадрат те из них, значения которых неотрицательны",
              "Задание 2",
              MessageBoxButton.OK,
              MessageBoxImage.Asterisk);
        }

        private void mItEx3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дан массив действительных чисел a1,...,an. " +
                "Получить количество отрицательных членов массива a1,..,an " +
                "и произведение элементов, принадлежащих отрезку [с,в]",
              "Задание 3",
              MessageBoxButton.OK,
              MessageBoxImage.Asterisk);
        }

        private void mItEx4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана матрица размера М х N. Преобразовать матрицу, " +
                "поменяв местами минимальный и максимальный элемент",
              "Задание 4",
              MessageBoxButton.OK,
              MessageBoxImage.Asterisk);
        }

        private void mItDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Юсифова Рафаэля",
               "Разработчик",
               MessageBoxButton.OK,
               MessageBoxImage.Asterisk);
        }

        //Ex1
        private void mItExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCountEx1_Click(object sender, RoutedEventArgs e)
        {
            Ex1 ex1 = new Ex1(Convert.ToInt32(txtbNumber.Text));

            int eqRes = ex1.Equals();

            try
            {
                if (eqRes == 1)
                {
                    MessageBox.Show("Цифры числа равны",
                        "Результат",
                        MessageBoxButton.OK,
                        MessageBoxImage.Asterisk);
                }
                else
                {
                    MessageBox.Show("Цифры числа НЕ равны",
                       "Результат",
                       MessageBoxButton.OK,
                       MessageBoxImage.Asterisk);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCleanEx1_Click(object sender, RoutedEventArgs e)
        {
            txtbNumber.Clear();
        }

        //Ex2
        private void btnCountEx2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int result1, result2, result3;
                Ex2.SquareNumber(Convert.ToInt32(txtbNumber1.Text), Convert.ToInt32(txtbNumber2.Text), Convert.ToInt32(txtbNumber3.Text), out result1, out result2, out result3);
                MessageBox.Show($" {result1}, {result2}, {result3}",
                    "Результат",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCleanEx2_Click(object sender, RoutedEventArgs e)
        {
            txtbNumber1.Clear();
            txtbNumber2.Clear();
            txtbNumber3.Clear();
        }

        //Ex3
        private void btnCountEx3_Click(object sender, RoutedEventArgs e)
        {
            //Количество
            int countRes = Ex3.NegativeCount(thisArray);
            txtbResulCountEx3.Text = String.Join(" ", countRes);

            //Произведение
            double[] resultMult = thisArray.Multiplay();
            txtbResulPrEx3.Text = String.Join(" ", resultMult);
        }

        Array<int> thisArray;

        /// <summary>
        /// Создание и заполнение массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateFillEx3_Click(object sender, RoutedEventArgs e)
        {
            bool capacityValueCheck = int.TryParse(txtbElementsCount.Text, out int capacityValue);

            if (!(capacityValueCheck || capacityValue < 0))
            {
                MessageBox.Show("Данные введены неверно!");
            }
            else
            {
                thisArray = new Array<int>(capacityValue);
                thisArray.Fill(capacityValue);

                dGArrays.ItemsSource = thisArray.DTOneDimArray().DefaultView;
            }
        }

        private void txtbElementsCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbResulCountEx3.Clear();
            txtbResulPrEx3.Clear();
        }

        private void btnCleanEx3_Click(object sender, RoutedEventArgs e)
        {
            txtbElementsCount.Clear();
            txtbResulCountEx3.Clear();
            txtbResulPrEx3.Clear();
        }

        //Ex4

        int[,] matrix;
        private void btnCreateFillEx4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                matrix = new int[Int32.Parse(txtbColumnsEx4.Text), Int32.Parse(txtbRowsEx4.Text)];
                Random random = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(-10, 10);
                    }
                }
                dataGrid.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnCountEx4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ex4.SwapMaxMin(matrix);
                dataGrid.ItemsSource = matrix.ToDataTable().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void btnCleanEx4_Click(object sender, RoutedEventArgs e)
        {
            txtbColumnsEx4.Clear();
            txtbRowsEx4.Clear();
        }

       
    }
}
