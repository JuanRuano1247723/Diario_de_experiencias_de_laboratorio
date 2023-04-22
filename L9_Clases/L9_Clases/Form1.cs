using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L9_Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Automovil myAutomovil = new Automovil();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // obtener datos, guardarlos en la clase
            myAutomovil.DefinirPrecio(Convert.ToDouble(txt_precio.Text));
            myAutomovil.DefinirModelo(Convert.ToInt32(txt_modelo.Text));
            myAutomovil.DefinirMarca(txt_marca.Text);
            myAutomovil.DefinirTipoCambio(Convert.ToDouble(txt_cambio.Text));

            //Mostramos un mensaje en pantalla
            MessageBox.Show("Los datos fueron guardados exitosamente");

            txt_datos.Text = myAutomovil.MostrarInformacion();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_marca.Clear();
            txt_modelo.Clear();
            txt_precio.Clear();
            txt_documento.Clear();
            txt_datos.Clear();
        }

        //definir procedimiento y funciones
        public void DefinirModelo(int unModelo)
        {

        }
        public void DefinirPrecio(double unPrecio)
        {

        }
        public void DefinirMarca(double unMarca)
        {

        }


    }
}
