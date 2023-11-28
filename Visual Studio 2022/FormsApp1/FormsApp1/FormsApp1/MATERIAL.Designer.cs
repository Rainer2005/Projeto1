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
            this.m1 = new System.Windows.Forms.RadioButton();
            this.p2 = new System.Windows.Forms.RadioButton();
            this.c1 = new System.Windows.Forms.RadioButton();
            this.p1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editar_servico = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.cadastro_servico.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // valor_m2
            // 
            this.valor_m2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valor_m2.Location = new System.Drawing.Point(6, 22);
            this.valor_m2.Name = "valor_m2";
            this.valor_m2.Size = new System.Drawing.Size(216, 23);
            this.valor_m2.TabIndex = 10;
            this.valor_m2.TextChanged += new System.EventHandler(this.valor_m2_TextChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(222, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VALOR POR M²";
            // 
            // cadastro_servico
            // 
            this.cadastro_servico.Controls.Add(this.m1);
            this.cadastro_servico.Controls.Add(this.p2);
            this.cadastro_servico.Controls.Add(this.c1);
            this.cadastro_servico.Controls.Add(this.p1);
            this.cadastro_servico.Location = new System.Drawing.Point(222, 56);
            this.cadastro_servico.Name = "cadastro_servico";
            this.cadastro_servico.Size = new System.Drawing.Size(228, 81);
            this.cadastro_servico.TabIndex = 14;
            this.cadastro_servico.TabStop = false;
            this.cadastro_servico.Text = "Digite o Serviço";
            this.cadastro_servico.Enter += new System.EventHandler(this.cadastro_servico_Enter);
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Location = new System.Drawing.Point(128, 48);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(54, 19);
            this.m1.TabIndex = 3;
            this.m1.TabStop = true;
            this.m1.Text = "Muro";
            this.m1.UseVisualStyleBackColor = true;
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(128, 26);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(63, 19);
            this.p2.TabIndex = 2;
            this.p2.TabStop = true;
            this.p2.Text = "Pintura";
            this.p2.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(23, 48);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 19);
            this.c1.TabIndex = 1;
            this.c1.TabStop = true;
            this.c1.Text = "Ceramica";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(23, 26);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(88, 19);
            this.p1.TabIndex = 0;
            this.p1.TabStop = true;
            this.p1.Text = "Porcelanato";
            this.p1.UseVisualStyleBackColor = true;
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
            this.tabPage1.Controls.Add(this.cadastro_servico);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.salvar_servico);
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
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(75, 55);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(558, 198);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Serviços";
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
        private RadioButton m1;
        private RadioButton p2;
        private RadioButton c1;
        private RadioButton p1;
        private Button editar_servico;
        private GroupBox groupBox8;
    }
}