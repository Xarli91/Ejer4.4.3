using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4._4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;

            MessageBox.Show("Name is " + name + "\nx is " + x + "\nd is " + d);

            /*  \n: Sirve para hacer un salto de línea en la cadena de texto que se muestra en el MessageBox.
             *  La función PI es una constante matemática que vale: 3.14159265358979
             *  El valor de d es igual a Math.PI / 2= 1.5707963267948966. */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            while (cont < 10)
            {
                cont = cont + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                cont = cont - 1;
            }
            MessageBox.Show("La respuesta es: " + cont);

            //El valor de cont es 5.
            //Ya que en el bucle se aumenta en 1 / 10 veces, y en el for se reduce en 1 / 5 veces
        }
    }
}
