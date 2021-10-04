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

namespace Calculator_App_MOO_ICT
{
   
    public partial class MainWindow : Window
    {
        double num1; // this is double data type number called num1
        double num2; // this is double data type number called num2
        double totalNumber; // this is the double data number called totalNumber this will be used to show the total calculation

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddingNumbers(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(numerA.Text); // catch the text from the number A text box and convert to a double data type
            num2 = Convert.ToDouble(numerB.Text); // catch the text from the  number B text box and convert to a double data type

            totalNumber = num1 + num2; // add the two numbers together and place them in the total number variable

            result.Content = totalNumber.ToString(); // show the total number on the result label
        }

        private void SubtractNumbers(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(numerA.Text); // catch the text from the number A text box and convert to a double data type
            num2 = Convert.ToDouble(numerB.Text); // catch the text from the  number B text box and convert to a double data type

            totalNumber = num1 - num2; // substract the two numbers together and place them in the total number variable

            result.Content = totalNumber.ToString(); // show the total number on the result label
        }

        private void MultiplyNumbers(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(numerA.Text); // catch the text from the number A text box and convert to a double data type
            num2 = Convert.ToDouble(numerB.Text); // catch the text from the  number B text box and convert to a double data type

            totalNumber = num1 * num2; // multiply the two numbers together and place them in the total number variable

            result.Content = totalNumber.ToString(); // show the total number on the result label
        }

        private void DivideNumbers(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(numerA.Text); // catch the text from the number A text box and convert to a double data type
            num2 = Convert.ToDouble(numerB.Text); // catch the text from the  number B text box and convert to a double data type

            totalNumber = num1 / num2; // divide the two numbers together and place them in the total number variable

            totalNumber = Math.Round(totalNumber, 2); // round the numbers down 2 decimal points

            result.Content = totalNumber.ToString(); // show the total number on the result label
        }
    }
}
