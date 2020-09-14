using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
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
    public partial class MainWindow : Window
    {
        //Variables
        private double number1= 0, number2 = 0;

        private string operation = "";
                
        public MainWindow()
        {
            InitializeComponent();
        }

        //Numbers buttons
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Result.Text = number2.ToString();
            }
        }

        //Operations buttons
        private void Button_Click_10(object sender, RoutedEventArgs e)//Addition
        {
            operation = "+";
            Result.Text = "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)//Substraction
        {
            operation = "-";
            Result.Text = "0";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)//Multiplication
        {
            operation = "*";
            Result.Text = "0";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)//Division
        {
            operation = "/";
            Result.Text = "0";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)//Result
        {
            switch (operation)
            {
                case "+":
                    Result.Text = Suma(number1, number2).ToString();
                    number1 = Suma(number1, number2);
                    break;

                case "-":
                    Result.Text = Resta(number1, number2).ToString();
                    number1 = Resta(number1, number2);
                    break;

                case "*":
                    Result.Text = Multiplicacion(number1, number2).ToString();
                    number1 = Multiplicacion(number1, number2);
                    break;

                case "/":
                    if (number2 == 0)
                    {
                        Result.Text = "No se puede dividir por 0";
                    }
                    else
                    {
                        Result.Text = Division(number1, number2).ToString();
                        number1 = Division(number1, number2);
                    }                 
                    break;
            }

            operation = "";
            number2 = 0;
                 
        }      

        //Operations
        private double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        private double Resta(double num1, double num2)
        {
            return num1 - num2;
        }

        private double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }
        private double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)//CE
        {
            if (operation == "")
            {
                number1 = 0;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = 0;
                Result.Text = number2.ToString();
            }            
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)//±
        {
            if (operation == "")
            {
                number1 *= -1;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                Result.Text = number2.ToString();
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)//C
        {
            operation = "";
            number1 = 0; 
            number2 = 0;
            Result.Text = 0.ToString();
        }        
    }
}