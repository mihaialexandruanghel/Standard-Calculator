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
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double memory = 0;
        double number1 = 0;
        double number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }



        //Number Buttons
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "1";
                }

                else
                {
                    number1 = (number1 * 10) + 1;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number2.ToString();

            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "2";
                }

                else
                {
                    number1 = (number1 * 10) + 2;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {

                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "3";
                }

                else
                {
                    number1 = (number1 * 10) + 3;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "4";
                }

                else
                {
                    number1 = (number1 * 10) + 4;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "5";
                }

                else
                {
                    number1 = (number1 * 10) + 5;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "6";
                }

                else
                {
                    number1 = (number1 * 10) + 6;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "7";
                }

                else
                {
                    number1 = (number1 * 10) + 7;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "8";
                }

                else
                {
                    number1 = (number1 * 10) + 8;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "9";
                }

                else
                {
                    number1 = (number1 * 10) + 9;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + "0";
                }

                else
                {
                    number1 = (number1 * 10) + 0;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = (number2 * 10);
                txtDisplay.Text = number2.ToString();
            }
        }


        //dot
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {

            txtDisplay.Text = number1.ToString() + ".";

        }


        //Math Bottons
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
            txtDisplay.Text = (number1 + number2).ToString();
            number1 = Convert.ToDouble(txtDisplay.Text);
            number2 = 0;

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
            txtDisplay.Text = (number1 - number2).ToString();
            number1 = Convert.ToDouble(txtDisplay.Text);
            number2 = 0;
        }

        private void btTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
            txtDisplay.Text = (number1 * number2).ToString();
            number1 = Convert.ToDouble(txtDisplay.Text);
            number2 = 0;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
            txtDisplay.Text = (number1 / number2).ToString();
            number1 = Convert.ToDouble(txtDisplay.Text);
            number2 = 0;
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            operation = "%";
            txtDisplay.Text = "0";
            txtDisplay.Text = ((number1 * number2) / 100.0).ToString();
            number1 = Convert.ToDouble(txtDisplay.Text);
            number2 = 0;
        }
        private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (memory > 0)
            {
                number1 = memory;
            }
            txtDisplay.Text = (Math.Sqrt(number1)).ToString();
            number1 = Convert.ToDouble(txtDisplay.Text);
            number2 = 0;
        }

        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            if (memory > 0)
            {
                number1 = memory;
            }
            txtDisplay.Text = (Math.Pow(number1, 2)).ToString();
            number1 = Convert.ToDouble(txtDisplay.Text);
            number2 = 0;
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = (1 / number1).ToString();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    if (memory > 0)
                    {
                        number2 = memory;
                    }
                    txtDisplay.Text = (number1 + number2).ToString();
                    number1 = Convert.ToDouble(txtDisplay.Text);
                    number2 = 0;
                    break;
                case "-":
                    if (memory > 0)
                    {
                        number2 = memory;
                    }
                    txtDisplay.Text = (number1 - number2).ToString();
                    number1 = Convert.ToDouble(txtDisplay.Text);
                    number2 = 0;
                    break;
                case "*":
                    if (memory > 0)
                    {
                        number2 = memory;
                    }
                    txtDisplay.Text = (number1 * number2).ToString();
                    number1 = Convert.ToDouble(txtDisplay.Text);
                    number2 = 0;
                    break;
                case "/":
                    if (memory > 0)
                    {
                        number2 = memory;
                    }
                    txtDisplay.Text = (number1 / number2).ToString();
                    number1 = Convert.ToDouble(txtDisplay.Text);
                    number2 = 0;
                    break;
                case "%":
                    if (memory > 0)
                    {
                        number2 = memory;
                    }
                    txtDisplay.Text = ((number1 * number2) / 100.0).ToString();
                    number1 = Convert.ToDouble(txtDisplay.Text);
                    number2 = 0;
                    break;
            }
        }





        //Clear Buttons
        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                txtDisplay.Text = number2.ToString();
            }
        }






        //M Buttons
        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
        }

        private void btnMR_Click(object sender, RoutedEventArgs e)
        {


            txtDisplay.Text = memory.ToString();

        }

        private void btnMS_Click(object sender, RoutedEventArgs e)
        {
            memory = number1;
        }

        private void btnM_plus_Click(object sender, RoutedEventArgs e)
        {
            memory = memory + Convert.ToDouble(txtDisplay.Text);
        }

        private void btnM_minus_Click(object sender, RoutedEventArgs e)
        {
            memory = memory - Convert.ToDouble(txtDisplay.Text);

        }

        //copy
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
        }

        //paste
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

            string pasteTxt = Clipboard.GetText();
            string cleanPastable = "";
            for (int charIndex = 0; charIndex < pasteTxt.Length; charIndex++)
            {
                if (char.IsDigit(pasteTxt[charIndex]))
                    cleanPastable += pasteTxt[charIndex];
            }
            txtDisplay.Text = cleanPastable;
        }

        //close
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }




        //about
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }

        //cut
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
            txtDisplay.Text = "";
        }

    }
}
