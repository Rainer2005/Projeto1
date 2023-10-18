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
            this.label1 = new System.Windows.Forms.Label();
            this.SERVICO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valor_m2 = new System.Windows.Forms.TextBox();
            this.editar_servico = new System.Windows.Forms.Button();
            this.salvar_servico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE O SERVIÇO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SERVICO
            // 
            this.SERVICO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SERVICO.FormattingEnabled = true;
            this.SERVICO.Location = new System.Drawing.Point(384, 61);
            this.SERVICO.Name = "SERVICO";
            this.SERVICO.Size = new System.Drawing.Size(149, 23);
            this.SERVICO.TabIndex = 1;
            this.SERVICO.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "QUAL O VALOR POR M²";
            // 
            // valor_m2
            // 
            this.valor_m2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valor_m2.Location = new System.Drawing.Point(211, 154);
            this.valor_m2.Name = "valor_m2";
            this.valor_m2.Size = new System.Drawing.Size(86, 23);
            this.valor_m2.TabIndex = 10;
            // 
            // editar_servico
            // 
            this.editar_servico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editar_servico.Location = new System.Drawing.Point(565, 440);
            this.editar_servico.Name = "editar_servico";
            this.editar_servico.Size = new System.Drawing.Size(113, 28);
            this.editar_servico.TabIndex = 11;
            this.editar_servico.Text = "EDITAR";
            this.editar_servico.UseVisualStyleBackColor = false;
            // 
            // salvar_servico
            // 
            this.salvar_servico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salvar_servico.Location = new System.Drawing.Point(693, 440);
            this.salvar_servico.Name = "salvar_servico";
            this.salvar_servico.Size = new System.Drawing.Size(113, 28);
            this.salvar_servico.TabIndex = 12;
            this.salvar_servico.Text = "SALVAR";
            this.salvar_servico.UseVisualStyleBackColor = false;
            this.salvar_servico.Click += new System.EventHandler(this.salvar_servico_Click);
            // 
            // FRM_SERVICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(818, 485);
            this.Controls.Add(this.salvar_servico);
            this.Controls.Add(this.editar_servico);
            this.Controls.Add(this.valor_m2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SERVICO);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_SERVICO";
            this.Text = "SERVIÇO";
            this.Load += new System.EventHandler(this.MATERIAL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox SERVICO;
        private Label label5;
        private TextBox valor_m2;
        private Button editar_servico;
        private Button salvar_servico;
    }
}