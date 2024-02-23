using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_de_metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int SumaEnteros (int n1, int n2)//declaracion de funcion
        {
            return n1+n2;
        }
        private void MuestraMensaje(String s)//declaracion de procedimiento 
        {
            MessageBox.Show(s);
        }
        private void button1_Click(object sender, EventArgs e) //metodo priv
        {
            int a = 5;
            int b = 8;
            int resul = SumaEnteros(a, b);//invocacion de funcion 
            MessageBox.Show(resul.ToString());
            MuestraMensaje("Hola mundo");
        }

    }
}
