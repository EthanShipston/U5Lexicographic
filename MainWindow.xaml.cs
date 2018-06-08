/* Ethan Shipston
 * U5Lexicographic
 * 6/7/2018
 * A program that tells you a number
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U5Lexicographic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int[] numbers = new int[1000000];
            int first = 0123456789;
            numbers[0] = first;
            bool carryOn = false;
            int counter = 1;
            while (numbers[2] == 0)
            {
                int.TryParse(first.ToString().Substring(first.ToString().Length - counter), out int currentLoop);
                int checkCounter = counter;
                while (carryOn = false)
                {
                    int.TryParse(currentLoop.ToString() + currentLoop.ToString().Substring(0, 1), out currentLoop);
                    int.TryParse(currentLoop.ToString().Remove(0, 1), out currentLoop);
                    int.TryParse(first.ToString().Remove(first.ToString().Length - currentLoop.ToString().Length, currentLoop.ToString().Length) + currentLoop.ToString(), out numbers[counter]);

                    if (numbers[counter - 1] > numbers[counter])
                    {
                        int temp = numbers[counter - 1];
                        numbers[counter - 1] = numbers[counter];
                        numbers[counter] = temp;
                    }
                    MessageBox.Show(numbers [counter - 1] + " " + numbers[counter].ToString());
                }
            }
        }
    }
}
