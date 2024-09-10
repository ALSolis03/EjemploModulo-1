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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            FormularioEntrada formEntrada = new FormularioEntrada();
            formEntrada.Show();
            this.Hide();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Form2 formSuma = new Form2();
            formSuma.Show();
            this.Hide();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            formConteo form = new formConteo();
            form.Show();
            this.Hide();
        }
    }
}
