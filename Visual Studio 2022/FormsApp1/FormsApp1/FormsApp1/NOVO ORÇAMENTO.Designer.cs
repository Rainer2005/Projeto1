namespace FormsApp1
{
    partial class NOVO_ORÇAMENTO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SERV_ORCAMENTO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.REJUNTE = new System.Windows.Forms.TextBox();
            this.ACII = new System.Windows.Forms.RadioButton();
            this.ACIII = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ARG_TOTAL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comprimento_m2 = new System.Windows.Forms.TextBox();
            this.largura_m2 = new System.Windows.Forms.TextBox();
            this.txtresult_m2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.resultado_m2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.larg_porcelanato = new System.Windows.Forms.TextBox();
            this.alt_porcelanato = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.quant_porcelanato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECIONE O SERVIÇO DESEJADO";
            // 
            // SERV_ORCAMENTO
            // 
            this.SERV_ORCAMENTO.FormattingEnabled = true;
            this.SERV_ORCAMENTO.Location = new System.Drawing.Point(229, 80);
            this.SERV_ORCAMENTO.Name = "SERV_ORCAMENTO";
            this.SERV_ORCAMENTO.Size = new System.Drawing.Size(121, 23);
            this.SERV_ORCAMENTO.TabIndex = 2;
            this.SERV_ORCAMENTO.SelectedIndexChanged += new System.EventHandler(this.SERV_ORCAMENTO_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "DIGITE O NOME DO CLIENTE";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(189, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "DIGITE O TAMANHO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUANTOS M²";
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(99, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "ARGAMASSA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "NIVELADORES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "REJUNTE";
            // 
            // REJUNTE
            // 
            this.REJUNTE.Location = new System.Drawing.Point(76, 280);
            this.REJUNTE.Name = "REJUNTE";
            this.REJUNTE.Size = new System.Drawing.Size(121, 23);
            this.REJUNTE.TabIndex = 15;
            // 
            // ACII
            // 
            this.ACII.AutoSize = true;
            this.ACII.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ACII.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ACII.Location = new System.Drawing.Point(145, 203);
            this.ACII.Name = "ACII";
            this.ACII.Size = new System.Drawing.Size(47, 19);
            this.ACII.TabIndex = 17;
            this.ACII.TabStop = true;
            this.ACII.Tag = "";
            this.ACII.Text = "ACII";
            this.ACII.UseVisualStyleBackColor = true;
            // 
            // ACIII
            // 
            this.ACIII.AutoSize = true;
            this.ACIII.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ACIII.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ACIII.Location = new System.Drawing.Point(198, 203);
            this.ACIII.Name = "ACIII";
            this.ACIII.Size = new System.Drawing.Size(50, 19);
            this.ACIII.TabIndex = 18;
            this.ACIII.TabStop = true;
            this.ACIII.Tag = "";
            this.ACIII.Text = "ACIII";
            this.ACIII.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton3.Location = new System.Drawing.Point(103, 246);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 19);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "";
            this.radioButton3.Text = "SIM";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton4.Location = new System.Drawing.Point(171, 246);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 19);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "";
            this.radioButton4.Text = "NÃO";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(644, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "GRAVAR ORÇAMENTO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(499, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 31);
            this.button2.TabIndex = 22;
            this.button2.Text = "ADICIONAR SERVIÇO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "ARGAMASSA TOTAL";
            // 
            // ARG_TOTAL
            // 
            this.ARG_TOTAL.Location = new System.Drawing.Point(130, 319);
            this.ARG_TOTAL.Name = "ARG_TOTAL";
            this.ARG_TOTAL.Size = new System.Drawing.Size(126, 23);
            this.ARG_TOTAL.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(12, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "NIVELADORES TOTAL";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 357);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 23);
            this.textBox3.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(611, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "CALCULADORA M²";
            // 
            // comprimento_m2
            // 
            this.comprimento_m2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comprimento_m2.Location = new System.Drawing.Point(634, 72);
            this.comprimento_m2.Name = "comprimento_m2";
            this.comprimento_m2.Size = new System.Drawing.Size(65, 23);
            this.comprimento_m2.TabIndex = 28;
            this.comprimento_m2.TextChanged += new System.EventHandler(this.comprimento_m2_TextChanged);
            // 
            // largura_m2
            // 
            this.largura_m2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.largura_m2.Location = new System.Drawing.Point(634, 101);
            this.largura_m2.Name = "largura_m2";
            this.largura_m2.Size = new System.Drawing.Size(65, 23);
            this.largura_m2.TabIndex = 29;
            this.largura_m2.TextChanged += new System.EventHandler(this.largura_m2_TextChanged);
            this.largura_m2.Leave += new System.EventHandler(this.largura_m2_Leave);
            // 
            // txtresult_m2
            // 
            this.txtresult_m2.Location = new System.Drawing.Point(634, 130);
            this.txtresult_m2.Name = "txtresult_m2";
            this.txtresult_m2.Size = new System.Drawing.Size(65, 23);
            this.txtresult_m2.TabIndex = 30;
            this.txtresult_m2.TextChanged += new System.EventHandler(this.result_m2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(526, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "COMPRIMENTO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(549, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "RESULTADO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(559, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "LARGURA";
            // 
            // resultado_m2
            // 
            this.resultado_m2.AutoSize = true;
            this.resultado_m2.Location = new System.Drawing.Point(644, 138);
            this.resultado_m2.Name = "resultado_m2";
            this.resultado_m2.Size = new System.Drawing.Size(0, 15);
            this.resultado_m2.TabIndex = 31;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(95, 203);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 19);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "";
            this.radioButton1.Text = "ACI";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // larg_porcelanato
            // 
            this.larg_porcelanato.Location = new System.Drawing.Point(190, 123);
            this.larg_porcelanato.Name = "larg_porcelanato";
            this.larg_porcelanato.Size = new System.Drawing.Size(31, 23);
            this.larg_porcelanato.TabIndex = 33;
            this.larg_porcelanato.TextChanged += new System.EventHandler(this.larg_porcelanato_TextChanged);
            // 
            // alt_porcelanato
            // 
            this.alt_porcelanato.Location = new System.Drawing.Point(133, 124);
            this.alt_porcelanato.Name = "alt_porcelanato";
            this.alt_porcelanato.Size = new System.Drawing.Size(31, 23);
            this.alt_porcelanato.TabIndex = 34;
            this.alt_porcelanato.TextChanged += new System.EventHandler(this.alt_porcelanato_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(170, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(226, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Altura X Largura em cm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "QUANTIDADE DE PEÇAS";
            // 
            // quant_porcelanato
            // 
            this.quant_porcelanato.Location = new System.Drawing.Point(163, 393);
            this.quant_porcelanato.Name = "quant_porcelanato";
            this.quant_porcelanato.Size = new System.Drawing.Size(106, 23);
            this.quant_porcelanato.TabIndex = 38;
            this.quant_porcelanato.TextChanged += new System.EventHandler(this.quant_porcelanato_TextChanged);
            this.quant_porcelanato.Leave += new System.EventHandler(this.result_m2_TextChanged);
            // 
            // NOVO_ORÇAMENTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quant_porcelanato);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.alt_porcelanato);
            this.Controls.Add(this.larg_porcelanato);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.resultado_m2);
            this.Controls.Add(this.comprimento_m2);
            this.Controls.Add(this.largura_m2);
            this.Controls.Add(this.txtresult_m2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ARG_TOTAL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.ACIII);
            this.Controls.Add(this.ACII);
            this.Controls.Add(this.REJUNTE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SERV_ORCAMENTO);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "NOVO_ORÇAMENTO";
            this.Text = "NOVO_ORÇAMENTO";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.NOVO_ORÇAMENTO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox SERV_ORCAMENTO;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox REJUNTE;
        private RadioButton ACII;
        private RadioButton ACIII;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private Button button2;
        private Label label8;
        private TextBox ARG_TOTAL;
        private Label label9;
        private TextBox textBox3;
        private Label label10;
        private TextBox comprimento_m2;
        private TextBox largura_m2;
        private TextBox txtresult_m2;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label resultado_m2;
        private RadioButton radioButton1;
        private TextBox larg_porcelanato;
        private TextBox alt_porcelanato;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox quant_porcelanato;
    }
}