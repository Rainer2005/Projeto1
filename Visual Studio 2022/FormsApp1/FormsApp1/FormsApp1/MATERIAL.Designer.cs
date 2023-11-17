namespace FormsApp1
{
    partial class FRM_SERVICO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SERVICO));
            this.valor_m2 = new System.Windows.Forms.TextBox();
            this.salvar_servico = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cadastro_servico = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.editar_servico = new System.Windows.Forms.Button();
            this.cad_porcelanato = new System.Windows.Forms.RadioButton();
            this.cad_ceramica = new System.Windows.Forms.RadioButton();
            this.cad_pintura = new System.Windows.Forms.RadioButton();
            this.cad_muro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.cadastro_servico.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // valor_m2
            // 
            this.valor_m2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valor_m2.Location = new System.Drawing.Point(15, 22);
            this.valor_m2.Name = "valor_m2";
            this.valor_m2.Size = new System.Drawing.Size(195, 23);
            this.valor_m2.TabIndex = 10;
            // 
            // salvar_servico
            // 
            this.salvar_servico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salvar_servico.Location = new System.Drawing.Point(571, 399);
            this.salvar_servico.Name = "salvar_servico";
            this.salvar_servico.Size = new System.Drawing.Size(113, 28);
            this.salvar_servico.TabIndex = 12;
            this.salvar_servico.Text = "SALVAR";
            this.salvar_servico.UseVisualStyleBackColor = false;
            this.salvar_servico.Click += new System.EventHandler(this.salvar_servico_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valor_m2);
            this.groupBox1.Location = new System.Drawing.Point(31, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 67);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VALOR POR M²";
            // 
            // cadastro_servico
            // 
            this.cadastro_servico.Controls.Add(this.cad_muro);
            this.cadastro_servico.Controls.Add(this.cad_pintura);
            this.cadastro_servico.Controls.Add(this.cad_ceramica);
            this.cadastro_servico.Controls.Add(this.cad_porcelanato);
            this.cadastro_servico.Location = new System.Drawing.Point(31, 20);
            this.cadastro_servico.Name = "cadastro_servico";
            this.cadastro_servico.Size = new System.Drawing.Size(228, 81);
            this.cadastro_servico.TabIndex = 14;
            this.cadastro_servico.TabStop = false;
            this.cadastro_servico.Text = "Digite o Serviço";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 461);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.cadastro_servico);
            this.tabPage1.Controls.Add(this.salvar_servico);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adc Serviço";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editar_servico);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Serviço";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(275, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 154);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custo Adicional";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 23);
            this.textBox3.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(23, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 56);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(216, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 53);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Custo Embutido?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sim";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(90, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton4);
            this.groupBox6.Controls.Add(this.radioButton3);
            this.groupBox6.Location = new System.Drawing.Point(216, 81);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(169, 56);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sempre Adicionar Custo?";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(22, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 19);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sim";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(90, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 19);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Não";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Location = new System.Drawing.Point(23, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(167, 53);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nome";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(75, 55);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(558, 198);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Serviços";
            // 
            // editar_servico
            // 
            this.editar_servico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editar_servico.Location = new System.Drawing.Point(553, 399);
            this.editar_servico.Name = "editar_servico";
            this.editar_servico.Size = new System.Drawing.Size(113, 28);
            this.editar_servico.TabIndex = 12;
            this.editar_servico.Text = "EDITAR";
            this.editar_servico.UseVisualStyleBackColor = false;
            // 
            // cad_porcelanato
            // 
            this.cad_porcelanato.AutoSize = true;
            this.cad_porcelanato.Location = new System.Drawing.Point(23, 26);
            this.cad_porcelanato.Name = "cad_porcelanato";
            this.cad_porcelanato.Size = new System.Drawing.Size(88, 19);
            this.cad_porcelanato.TabIndex = 0;
            this.cad_porcelanato.TabStop = true;
            this.cad_porcelanato.Text = "Porcelanato";
            this.cad_porcelanato.UseVisualStyleBackColor = true;
            // 
            // cad_ceramica
            // 
            this.cad_ceramica.AutoSize = true;
            this.cad_ceramica.Location = new System.Drawing.Point(23, 48);
            this.cad_ceramica.Name = "cad_ceramica";
            this.cad_ceramica.Size = new System.Drawing.Size(75, 19);
            this.cad_ceramica.TabIndex = 1;
            this.cad_ceramica.TabStop = true;
            this.cad_ceramica.Text = "Ceramica";
            this.cad_ceramica.UseVisualStyleBackColor = true;
            // 
            // cad_pintura
            // 
            this.cad_pintura.AutoSize = true;
            this.cad_pintura.Location = new System.Drawing.Point(128, 26);
            this.cad_pintura.Name = "cad_pintura";
            this.cad_pintura.Size = new System.Drawing.Size(63, 19);
            this.cad_pintura.TabIndex = 2;
            this.cad_pintura.TabStop = true;
            this.cad_pintura.Text = "Pintura";
            this.cad_pintura.UseVisualStyleBackColor = true;
            // 
            // cad_muro
            // 
            this.cad_muro.AutoSize = true;
            this.cad_muro.Location = new System.Drawing.Point(128, 48);
            this.cad_muro.Name = "cad_muro";
            this.cad_muro.Size = new System.Drawing.Size(54, 19);
            this.cad_muro.TabIndex = 3;
            this.cad_muro.TabStop = true;
            this.cad_muro.Text = "Muro";
            this.cad_muro.UseVisualStyleBackColor = true;
            // 
            // FRM_SERVICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(818, 485);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_SERVICO";
            this.Text = "SERVIÇO";
            this.Load += new System.EventHandler(this.MATERIAL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cadastro_servico.ResumeLayout(false);
            this.cadastro_servico.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox valor_m2;
        private Button salvar_servico;
        private GroupBox groupBox1;
        private GroupBox cadastro_servico;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private GroupBox groupBox6;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private GroupBox groupBox5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private RadioButton cad_muro;
        private RadioButton cad_pintura;
        private RadioButton cad_ceramica;
        private RadioButton cad_porcelanato;
        private GroupBox groupBox7;
        private Button editar_servico;
        private GroupBox groupBox8;
    }
}