using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double baset = double.Parse(txt1.Text);
                double alturat = double.Parse(txt2.Text);
                double Area;

                baset = double.Parse(txt1.Text);
                alturat = double.Parse(txt2.Text);
                Area = baset * alturat / 2;

                txt3.Text = Area.ToString();

            }
            catch
            {
                MessageBox.Show("Dados inválidos informados!!!");
                //limpar os txts:
                txt3.Clear();
                txt1.Clear();
                txt2.Clear();
            }        
        }   
    }
}
