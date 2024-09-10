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
    
    public partial class FormularioSalida : Form
    {
        
        public FormularioSalida(String nombre,String cedula,Double salario)
        {
            double salarioNetoMensual, ISRAnual;
            InitializeComponent();
            lbSalidaNombre.Text = nombre;
            lbSalidaCedula.Text = cedula;
            lbSalidaSeguroSocial.Text = Convert.ToString(salario * 0.0975);
            lbSalidaSeguroEducativo.Text = Convert.ToString(salario * 0.0125);
            salarioNetoMensual = (salario - (salario * 0.0975) - (salario * 0.0125));

            ISRAnual = salarioNetoMensual * 13;

            if (ISRAnual < 11000){
                lbSalidaISRMensual.Text = "Usted no paga impuestos sobre la renta.";
                lbSalidaSalarioNeto.Text = Convert.ToString(salarioNetoMensual);
            } else if (ISRAnual > 11000 && ISRAnual < 50000){
                ISRAnual= (ISRAnual - 11000)*0.15;
                lbSalidaISRMensual.Text = Convert.ToString(ISRAnual / 13);
                lbSalidaSalarioNeto.Text = Convert.ToString(salarioNetoMensual - (ISRAnual / 13));
            } else {
                ISRAnual= (ISRAnual - 50000)*0.25+5850;
                lbSalidaISRMensual.Text = Convert.ToString(ISRAnual / 13);
                lbSalidaSalarioNeto.Text = Convert.ToString(salarioNetoMensual - (ISRAnual / 13));
            }

        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
