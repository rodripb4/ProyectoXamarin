using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            pick.Items.Add("Suma");
            pick.Items.Add("Resta");
            pick.Items.Add("Multiplicacion");
            pick.Items.Add("Division");
        }

        private void pick_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = pick.SelectedItem.ToString();

            int a = Int32.Parse(n1.Text);
            int b = Int32.Parse(n2.Text);
            double res = 0;

            if (op == "Suma")
            {
                res = a + b;
            }else if (op == "Resta")
            {
                res = a - b;
            }else if (op == "Multiplicacion")
            {
                res = a * b;
            }
            else
            {
                res = a / b;
            }

            rest.Text = res + "";
        }
    }
}
