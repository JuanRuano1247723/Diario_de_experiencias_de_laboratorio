using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L8Foms_JLDRL_1247723
{
    public partial class laboratorio_8 : Form
    {
        public laboratorio_8()
        {
            InitializeComponent();
        }  
        private void Cmbseleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_seleccion.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("hola super humano vamos a seleccionar la pestaña de sumatoria");
                    tabControl1.SelectedTab = tab_sumatoria;
                    break;
                case 1:
                    MessageBox.Show("hola super humano vamos a seleccionar la pestaña de tablas de multiplicar");
                    tabControl1.SelectedTab = tab_tablas;
                    break;
                case 2:
                    MessageBox.Show("hola super humano vamos a seleccionar la pestaña de número perfecto");
                    tabControl1.SelectedTab = tab_perfecto;
                    break;
                default:
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void laboratorio_8_Load(object sender, EventArgs e)
        {

        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void tab_sumatoria_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ejecutar_Click(object sender, EventArgs e)
        {
            txt_numero.Clear();
            lbl_ressum.Text = "";
            int i = 1;
            int suma = 0;
            int n1=0,k = 0, suma2=0, n2 = 0;
            bool n = int.TryParse(txt_numero.Text, out int num);
            if (n == true)
            {
                do
                {
                    suma = i + suma;
                    MessageBox.Show(i.ToString());
                    i++;
                } while (i <= num); 
               lbl_ressum.Text = suma.ToString();
            }
            else
            {
                MessageBox.Show("Opción no válida");
                txt_numero.Clear();
                lbl_ressum.Text = "";
            }
            n = int.TryParse(textBox1.Text, out num);
            if (n == true)
            {
                for (int j = 0; j <= n1; j++)
                {
                    int mul = j * n1;
                    MessageBox.Show(j + "*" + n1 + "=" + mul);
                }
            }
            else
            {
                MessageBox.Show("Opción no válida");
                textBox1.Clear();
            }
            n = int.TryParse(textBox2.Text, out num);
            if (n == true)
            {
                do
                {
                    if (k == n2)
                    {
                        break;
                    }
                    else if (n2 % k == 0)
                    {
                        suma2 += k;
                        MessageBox.Show(k.ToString());
                    }
                    k++;

                } while (k <= 28);
                MessageBox.Show(suma2.ToString());
                if (suma2 == n2)
                {
                    label2.Text = ("Es un número perfecto");
                }
                else
                {
                    label2.Text = ("No es un número perfecto");

                }
            }
            else
            {
                MessageBox.Show("Opción no válida");
                textBox2.Clear();
                label2.Text = "";
            }
        }

        private void tab_tablas_Click(object sender, EventArgs e)
        {

        }
    }
}
