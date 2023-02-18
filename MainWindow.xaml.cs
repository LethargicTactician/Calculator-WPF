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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string output = "";
        double temp = 0;
        
        string operation = "";
        double outputTemp;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            //casting the sender to type btn to get the name of a button that's clicked
            //the sender turns into a button event
            //which makes it easier for a switch statement to be used
            string name = ((Button)sender).Name;


            switch (name)
            {
                case "btnOne":
                    output += "1";
                    txtOutput.Text = output;
                    break;

                case "btnTwo":
                    output += "2";
                    txtOutput.Text = output;
                    break;

                case "btnThree":
                    output += "3";
                    txtOutput.Text = output;
                    break;

                case "btnFour":
                    output += "4";
                    txtOutput.Text = output;
                    break;

                case "btnFive":
                    output += "5";
                    txtOutput.Text = output;
                    break;

                case "btnSix":
                    output += "6";
                    txtOutput.Text = output;
                    break;

                case "btnSeven":
                    output += "7";
                    txtOutput.Text = output;
                    break;

                case "btnEight":
                    output += "8";
                    txtOutput.Text = output;
                    break;

                case "btnNine":
                    output += "9";
                    txtOutput.Text = output;
                    break;

                case "btnZero":
                    output += "0";
                    txtOutput.Text = output;
                    break;

                default:

                    break;
            }


        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
               // output -= temp;
                operation = "-";
            }
        }

        private void BtnPlaus_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "+";
            }
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                // output -= temp;
                operation = "/";
            }
        }

        private void BtnMulti_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                // output -= temp;
                operation = "*";
            }
        }

        private void BtnCLear_Click(object sender, RoutedEventArgs e)
        {
            //🚫

            output = "";
            txtOutput.Text = output;
            operation = "";
        }

        private void SquareMeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                //temp = double.Parse(output);
               double squire = double.Parse(output);
                temp = squire * squire;
                output = temp.ToString();
                txtOutput.Text = output;
                operation = "x2";
            }
        }



        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            //string operation = ((Button)sender).Name;

            switch (operation)
            {
                case "-":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    txtOutput.Text = output;
                    break;

                case "+":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    txtOutput.Text = output;
                    break;

                case "/":
                    outputTemp = temp/double.Parse(output);
                    output = outputTemp.ToString();
                    txtOutput.Text = output;
                    break;

                case "*":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    txtOutput.Text = output;
                    break;

                default:
                    break;
            }
        }


    }
}
