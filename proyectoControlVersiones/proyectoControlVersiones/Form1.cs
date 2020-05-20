using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoControlVersiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //20/05/2020
            string nombre = tNombre.Text;
            string apellidos = tApellidos.Text;
            string telefono = tTelefono.Text;
            string texto = "";
            texto = nombre + " " + apellidos + " " + telefono + "\n";

            tListaSocios.Text = tListaSocios.Text.Replace("\n", Environment.NewLine);
            tListaSocios.Text = tListaSocios.Text + texto;
        }
    }
}
