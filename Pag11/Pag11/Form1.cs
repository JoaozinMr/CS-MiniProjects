using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int tempoTotal = 0;

            int horas = Convert.ToInt32(txtHora.Text);
            int minutos = Convert.ToInt32(txtMin.Text);
            int segundos = Convert.ToInt32(txtSeg.Text);
           
            tempoTotal = horas * 3600 + minutos * 60 + segundos;

            lblResult.Text = tempoTotal.ToString() + " segundos.";

        }

        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            txtHora.Text = "0";
            txtMin.Text = "0";
            txtSeg.Text = "0";
            lblResult.Text = "";
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txtQuant.Text);
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            decimal valorDolar = preco * quantidade;
            decimal valorReal = valorDolar * Convert.ToDecimal(5.29);
            lblConvertido.Text = $"O valor a ser pago é: {valorReal.ToString("C")}"; 
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
           int anos = Convert.ToInt32(txtAnos.Text);
           int meses = Convert.ToInt32(txtMes.Text);
           int dias = Convert.ToInt32(txtDias.Text);
           int idadeTotal = anos * 365 + meses * 30 + dias;
           lbIdade.Text = idadeTotal.ToString() + " dias";
            
        }

        private void btnLimpaIdade_Click(object sender, EventArgs e)
        {
            txtAnos.Text = "0";
            txtMes.Text = "0";
            txtDias.Text = "0";
            lbIdade.Text = "";
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            decimal valorConta = Convert.ToDecimal(txtConta.Text);
            int dias = Convert.ToInt32(txtAtraso.Text);
            decimal taxaDiaria = valorConta / 100 * Convert.ToDecimal(0.05) * dias + Convert.ToDecimal(8.49);
            decimal total = valorConta + taxaDiaria;
            lblConta.Text = $"O valor a ser pago é: {total.ToString("C")}";

        }
    }
}
