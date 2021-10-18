using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using haber;
using haber2;

namespace Tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // haber nun = new haber();
        private void button1_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            double a = num.Next(1, 100);
            double b = num.Next(1, 100);
            decimal a1 = num.Next(1, 100);
            decimal b1 = num.Next(1, 100);
            MessageBox.Show(""+haber.hola.Numeros(a1,b1));
            MessageBox.Show("" + haber.hola.Division(a1, b1));
            MessageBox.Show("" + haber2.Class1.multipilcacio(a, b));
            MessageBox.Show(""+haber2.Class1.resta(a,b));
        }
    }
}
