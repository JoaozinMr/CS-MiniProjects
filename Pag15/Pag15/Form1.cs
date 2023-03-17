using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag15
{
    public partial class btnMaior : Form
    {
        public btnMaior()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string senha = txtPwd.Text;
            if (senha == "1234")
                MessageBox.Show("Acesso Permitido.");
            else MessageBox.Show("Acesso Negado.");
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            string nome = txtNomeP.Text;
            int quant = int.Parse(txtQuantP.Text);
            decimal preco = decimal.Parse(txtPrecoU.Text);

            decimal totalCompra = preco * quant;
            decimal totalFinal;
            decimal desconto;

            if (quant <= 5)
            {
                desconto = totalCompra * 2 / 100;
                totalFinal = totalCompra - desconto;
            }
            else if (quant <= 10)
            {
                desconto = totalCompra * 3 / 100;
                totalFinal = totalCompra - desconto;
            }
            else
            {
                desconto = totalCompra * 5 / 100;
                totalFinal = totalCompra - desconto;
            }

            lblDesconto.Text = "Desconto: " + desconto.ToString("C");
            lblValorFinal.Text = "Valor Final: " + totalFinal.ToString("C");
            lblValorTotal.Text = "Valor Total: " + totalCompra.ToString("C");


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {

        }
        decimal saldo = 100;
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            decimal valorTransferido = decimal.Parse(txtTransf.Text);
            saldo += valorTransferido;
            lblSaldo.Text = saldo.ToString("C");
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            lblConta.Text = txtConta.Text;
            lblTitular.Text = txtTitular.Text;
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            decimal valorTransferido = decimal.Parse(txtTransf.Text);
            saldo -= valorTransferido;
            lblSaldo.Text = saldo.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { int.Parse(txtN1.Text), int.Parse(txtN2.Text), int.Parse(txtN3.Text)};
            int[] ordemCrescente = arr.OrderBy(x => x).ToArray();
            lblMaior.Text = $"{ordemCrescente[0]} - {ordemCrescente[1]} - {ordemCrescente[2]}";
        }

        private void btnAng_Click(object sender, EventArgs e)
        {
            double ang1 = double.Parse(txtA1.Text);
            double ang2 = double.Parse(txtA2.Text);
            double ang3 = double.Parse(txtA3.Text);
            if (ang1 == 90 || ang2 == 90 || ang3 == 90) lblAng.Text = "Triângulo Retângulo";
            else if (ang1 > 90 || ang2 > 90 || ang3 > 90) lblAng.Text = "Triângulo Obtusângulo";
            else if (ang1 < 90 && ang2 < 90 && ang3 < 90) lblAng.Text = "Triângulo Acutângulo";
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            decimal valorEmprestimo = decimal.Parse(txtEmpres.Text);
            int parcelas = int.Parse(txtParcelas.Text);
            decimal salario = decimal.Parse(txtSalar.Text);
            decimal valorParcela = valorEmprestimo / parcelas;

            if (valorParcela > salario * 30 / 100) lblEmprestimo.Text = "Empréstimo negado!";
            else lblEmprestimo.Text = "Empréstimo liberado!";
        }

        private void btnEx07_Click(object sender, EventArgs e)
        {
            int[] arr = { int.Parse(txtNum1.Text), int.Parse(txtNum2.Text), int.Parse(txtNum3.Text)};
            lblEx07.Text ="Maior Valor: " + arr.Max().ToString();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void btnDiaria_Click(object sender, EventArgs e)
        {
            string nome = txtCliente.Text;
            int dias = int.Parse(txtDiaria.Text);
            double diaria;

            if (dias > 15)
                diaria = 10 * dias;
            else if (dias < 15)
                diaria = 15 * dias;
            else diaria = 12 * dias;

            lblDiaria.Text = $"{nome}: {diaria.ToString("C")}";

        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            string nome = txtAluno.Text;
            string matricula = txtMatricula.Text;
            double[] notas = { double.Parse(txtNota1.Text), double.Parse(txtNota2.Text), double.Parse(txtNota3.Text) };
            double media = notas.Sum() / 3;
            string classificacao = "";

            if (media >= 9 && media <= 10) classificacao = "Conceito A";
            else if (media < 9 && media >= 7) classificacao = "Conceito B";
            else if (media < 7 && media >= 5) classificacao = "Conceito C";
            else if (media < 5 && media >= 3) classificacao = "Conceito D";
            else if (media < 3) classificacao = "Conceito R";

            lblNomeMatricula.Text = $"{nome} - {matricula}";
            lblNotaClass.Text = $"{media.ToString("00")} - {classificacao}";
        }
    }
}
