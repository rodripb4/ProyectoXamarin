using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //pick hace refernacia al picker que hemos puesto en el diseño. 
            //Esto lo que hara es meter estas opciones en el picker
            pick.Items.Add("Suma");
            pick.Items.Add("Resta");
            pick.Items.Add("Multiplicacion");
            pick.Items.Add("Division");
        }

        //Este metodo hara que cuando el usuario elija una opcion, reconozca el index del picker seleccionado 
        //lo pase a string y lo compare para hacer la operacion correcta.
        private void pick_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pasamos a string la opcion seleccionada por el usuario y la guardamos en una variable
            string op = pick.SelectedItem.ToString();
            //Pasamos a tipo int los dos numeros que ha introducido el usuario 
            int a = Int32.Parse(n1.Text);
            int b = Int32.Parse(n2.Text);
            double res = 0;

            //Aqui comparamos el string que hemos guardado en la variable op con lo que queremos que realice 
            //si coinciden pues entrara y se producira la operacion correspondiente 
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
            //El resultado se mostrara en un label que hemos referenciado con el nombre de rest
            rest.Text = res + "";
        }
    }
}
