using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Lic, yo se que solo pedía 2 funciones, pero no quería darle un tranajo "normal",es poco pero honesto :)

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Error
            if (NumTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(NumTextBox, "Escriba un número");
                return;
            }
            if (EjecutarButton.Text == String.Empty)
            {
                errorProvider1.SetError(NumTextBox, "Escriba un número");
                return;
            }
            errorProvider1.Clear();


            //Variables
            int Num1 = Convert.ToInt16(NumTextBox.Text);
            String R1,R2;

            //Saber si es par ó impar
            int PoI = Num1 % 2;
            if (PoI == 0) {
                R1 = "El número que ingresó es par.";
            }
            else
            {
                R1 = "El número que ingresó es impar.";
            }

            //Saber si el número es positivo ó negativo
            if ( Num1 >= 0)
            {
                R2 = "Positivo.";
            }
            else
            {
                R2 = "Negativo.";
            }

            //Mostrar
            PoITextBox.Text = R1;
            PoNTextBox.Text = R2;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
