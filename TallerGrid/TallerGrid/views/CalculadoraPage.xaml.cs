using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerGrid.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        private String number1;
        private String number2;
        private String operation;
        private List<String> operationsList = new List<string>();

		public Page1 ()
		{
			InitializeComponent ();
		}

        private void delete(String number)
        {
            Resultado.Text = number;
        }

        private void write(String number)
        {
            if (Resultado.Text != "0")
            {
                Resultado.Text += number;
            }
            else
            {
                delete(number);
            }
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            String number = "1";
            write(number);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            String number = "2";
            write(number);
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            String number = "3";
            write(number);
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            String number = "4";
            write(number);
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            String number = "5";
            write(number);
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            String number = "6";
            write(number);
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            String number = "7";
            write(number);
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            String number = "8";
            write(number);
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            String number = "9";
            write(number);
        }

        private void ButtonX_Clicked(object sender, EventArgs e)
        {
            number1 = Resultado.Text;
            operation = "Multiplicacion";
            Resultado.Text += String.Format("{0:00}", number1) + "*";
            operationsList.Add(number1);
            operationsList.Add(operation);
            Resultado.Text = "0";
        }

        private void ButtonS_Clicked(object sender, EventArgs e)
        {
            number1 = Resultado.Text;
            operation = "Sustracion";
            Resultado.Text += String.Format("{0:00}", number1) + "-";
            operationsList.Add(number1);
            operationsList.Add(operation);
            Resultado.Text = "0";
        }

        private void ButtonA_Clicked(object sender, EventArgs e)
        {
            number1 = Resultado.Text;
            operation = "suma";
            Resultado.Text += String.Format("{0:00}", number1) + "+";
            operationsList.Add(number1);
            operationsList.Add(operation);
            Resultado.Text = "0";
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            String number = "0";
            write(number);
        }

        private void ButtonP_Clicked(object sender, EventArgs e)
        {
            String number = ".";
            write(number);
        }

        private string Calculate(List<String> operationList)
        {
            double actualNumber = 0;
            for (int i = 0; i< operationsList.Count; i++)
            {
                switch (operationsList[i])
                {
                    case "percent":
                        actualNumber = actualNumber * Convert.ToDouble(operationList[i+1]) / 100;
                        i++;
                        break;
                    case "divi":
                        actualNumber = actualNumber * Convert.ToDouble(operationList[i + 1]);
                        i++;
                        break;
                    case "multi":
                        actualNumber = actualNumber * Convert.ToDouble(operationList[i + 1]);
                        i++;
                        break;
                    case "sustra":
                        actualNumber = actualNumber * Convert.ToDouble(operationList[i + 1]);
                        i++;
                        break;
                    case "adi":
                        actualNumber = actualNumber * Convert.ToDouble(operationList[i + 1]);
                        i++;
                        break;

                    default:
                        actualNumber = Convert.ToDouble(operationList[i]);
                        break;
                
                }
            }
            return actualNumber.ToString();
        }

        private void ButtonIG_Clicked(object sender, EventArgs e)
        {
            number2 = Resultado.Text;
            Resultado.Text += number2;
            operationsList.Add(number2);
            Resultado.Text = Calculate(operationsList);
        }

        private void ButtonC_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            Resultado.Text = "";
        }

        private void ButtonSign_Clicked(object sender, EventArgs e)
        {
            double stringNumber = Convert.ToDouble(Resultado.Text) / -1;
            Resultado.Text = stringNumber.ToString();
        }

        private void ButtonPercent_Clicked(object sender, EventArgs e)
        {
            number1 = Resultado.Text;
            operation = "percent";
            Resultado.Text += String.Format("{0:00}", number1) + "%";
            operationsList.Add(number1);
            operationsList.Add(operation);
            Resultado.Text = "0";

        }

        private void ButtonDiv_Clicked(object sender, EventArgs e)
        {
            number1 = Resultado.Text;
            operation = "div";
            Resultado.Text += String.Format("{0:00}", number1) + "/";
            operationsList.Add(number1);
            operationsList.Add(operation);
            Resultado.Text = "0";
        }
    }
}