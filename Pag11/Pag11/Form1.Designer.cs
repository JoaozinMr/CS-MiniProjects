namespace Pag11
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtSeg = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnLimpar1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblConvertido = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpaIdade = new System.Windows.Forms.Button();
            this.lbIdade = new System.Windows.Forms.Label();
            this.btnIdade = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtAnos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.btnConta = new System.Windows.Forms.Button();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtAtraso = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar1);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.txtSeg);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ex01";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEMPO GASTO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HORAS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SEGUNDOS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MINUTOS:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(15, 91);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(91, 20);
            this.txtHora.TabIndex = 4;
            this.txtHora.Text = "0";
            // 
            // txtSeg
            // 
            this.txtSeg.Location = new System.Drawing.Point(15, 187);
            this.txtSeg.Name = "txtSeg";
            this.txtSeg.Size = new System.Drawing.Size(91, 20);
            this.txtSeg.TabIndex = 5;
            this.txtSeg.Text = "0";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(15, 140);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(91, 20);
            this.txtMin.TabIndex = 6;
            this.txtMin.Text = "0";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(145, 91);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(103, 34);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular Tempo";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(109, 29);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // btnLimpar1
            // 
            this.btnLimpar1.Location = new System.Drawing.Point(145, 150);
            this.btnLimpar1.Name = "btnLimpar1";
            this.btnLimpar1.Size = new System.Drawing.Size(103, 34);
            this.btnLimpar1.TabIndex = 9;
            this.btnLimpar1.Text = "Limpar";
            this.btnLimpar1.UseVisualStyleBackColor = true;
            this.btnLimpar1.Click += new System.EventHandler(this.btnLimpar1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblConvertido);
            this.groupBox2.Controls.Add(this.btnConverter);
            this.groupBox2.Controls.Add(this.txtQuant);
            this.groupBox2.Controls.Add(this.txtPreco);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(307, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ex02";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "QUANTIDADE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "PREÇO:    US$";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(104, 78);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.Text = "0";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(104, 25);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(100, 20);
            this.txtQuant.TabIndex = 3;
            this.txtQuant.Text = "0";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(25, 124);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(223, 50);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Calcular Valor";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblConvertido
            // 
            this.lblConvertido.AutoSize = true;
            this.lblConvertido.Location = new System.Drawing.Point(67, 194);
            this.lblConvertido.Name = "lblConvertido";
            this.lblConvertido.Size = new System.Drawing.Size(0, 13);
            this.lblConvertido.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpaIdade);
            this.groupBox3.Controls.Add(this.lbIdade);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnIdade);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMes);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDias);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAnos);
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 234);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ex03";
            // 
            // btnLimpaIdade
            // 
            this.btnLimpaIdade.Location = new System.Drawing.Point(145, 152);
            this.btnLimpaIdade.Name = "btnLimpaIdade";
            this.btnLimpaIdade.Size = new System.Drawing.Size(103, 34);
            this.btnLimpaIdade.TabIndex = 19;
            this.btnLimpaIdade.Text = "Limpar";
            this.btnLimpaIdade.UseVisualStyleBackColor = true;
            this.btnLimpaIdade.Click += new System.EventHandler(this.btnLimpaIdade_Click);
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(61, 31);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(0, 13);
            this.lbIdade.TabIndex = 18;
            // 
            // btnIdade
            // 
            this.btnIdade.Location = new System.Drawing.Point(145, 93);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(103, 34);
            this.btnIdade.TabIndex = 17;
            this.btnIdade.Text = "Calcular Idade";
            this.btnIdade.UseVisualStyleBackColor = true;
            this.btnIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(15, 142);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(91, 20);
            this.txtMes.TabIndex = 16;
            this.txtMes.Text = "0";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(15, 189);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(91, 20);
            this.txtDias.TabIndex = 15;
            this.txtDias.Text = "0";
            // 
            // txtAnos
            // 
            this.txtAnos.Location = new System.Drawing.Point(15, 93);
            this.txtAnos.Name = "txtAnos";
            this.txtAnos.Size = new System.Drawing.Size(91, 20);
            this.txtAnos.TabIndex = 14;
            this.txtAnos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "MESES:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "DIAS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "ANOS:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "IDADE:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblConta);
            this.groupBox4.Controls.Add(this.btnConta);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtConta);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtAtraso);
            this.groupBox4.Location = new System.Drawing.Point(307, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 234);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ex04";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(67, 196);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(0, 13);
            this.lblConta.TabIndex = 11;
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(25, 126);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(223, 50);
            this.btnConta.TabIndex = 10;
            this.btnConta.Text = "Calcular Valor";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(132, 27);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 9;
            this.txtConta.Text = "0";
            // 
            // txtAtraso
            // 
            this.txtAtraso.Location = new System.Drawing.Point(132, 80);
            this.txtAtraso.Name = "txtAtraso";
            this.txtAtraso.Size = new System.Drawing.Size(100, 20);
            this.txtAtraso.TabIndex = 8;
            this.txtAtraso.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "DIAS DE ATRASO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "VALOR DA CONTA: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 512);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Página 11 ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtSeg;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConvertido;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpaIdade;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAtraso;
    }
}

