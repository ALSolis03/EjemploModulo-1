using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FormularioEntrada : Form
    {
        /*
        Joseph Guerrero 2-754-1867
        Analía Solís 8-1015-955
        Grupo: 1GS122
         */
        string nombre, cedula;
        double salario;
        public FormularioEntrada()
        {
            InitializeComponent();
        }

        public void asignarValor()
        {
            nombre = txtNombre.Text;
            cedula = txtCedula.Text;
            salario = Convert.ToDouble(txtSalarioBruto.Text);
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            asignarValor();
            FormularioSalida form = new FormularioSalida(nombre, cedula, salario);
            form.Show();
            this.Hide();
        }
    }
}
