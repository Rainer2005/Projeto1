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
            this.SERVICO = new System.Windows.Forms.ComboBox();
            this.valor_m2 = new System.Windows.Forms.TextBox();
            this.editar_servico = new System.Windows.Forms.Button();
            this.salvar_servico = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SERVICO
            // 
            this.SERVICO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SERVICO.FormattingEnabled = true;
            this.SERVICO.Location = new System.Drawing.Point(15, 32);
            this.SERVICO.Name = "SERVICO";
            this.SERVICO.Size = new System.Drawing.Size(149, 23);
            this.SERVICO.TabIndex = 1;
            this.SERVICO.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // valor_m2
            // 
            this.valor_m2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valor_m2.Location = new System.Drawing.Point(11, 32);
            this.valor_m2.Name = "valor_m2";
            this.valor_m2.Size = new System.Drawing.Size(153, 23);
            this.valor_m2.TabIndex = 10;
            // 
            // editar_servico
            // 
            this.editar_servico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editar_servico.Location = new System.Drawing.Point(434, 360);
            this.editar_servico.Name = "editar_servico";
            this.editar_servico.Size = new System.Drawing.Size(113, 28);
            this.editar_servico.TabIndex = 11;
            this.editar_servico.Text = "EDITAR";
            this.editar_servico.UseVisualStyleBackColor = false;
            // 
            // salvar_servico
            // 
            this.salvar_servico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salvar_servico.Location = new System.Drawing.Point(562, 360);
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
            this.groupBox1.Location = new System.Drawing.Point(225, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 71);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VALOR POR M²";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SERVICO);
            this.groupBox2.Location = new System.Drawing.Point(225, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 71);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECIONE O SERVIÇO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 422);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.salvar_servico);
            this.tabPage1.Controls.Add(this.editar_servico);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox SERVICO;
        private TextBox valor_m2;
        private Button editar_servico;
        private Button salvar_servico;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}