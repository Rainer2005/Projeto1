namespace FormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.novo_orçamento3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CAD_SERVICO = new System.Windows.Forms.Button();
            this.CAD_CLIENTE = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.novo_orçamento3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ORÇAMENTO";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button5.Location = new System.Drawing.Point(224, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 42);
            this.button5.TabIndex = 2;
            this.button5.Text = "AGENDAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // novo_orçamento3
            // 
            this.novo_orçamento3.BackColor = System.Drawing.Color.White;
            this.novo_orçamento3.Location = new System.Drawing.Point(224, 56);
            this.novo_orçamento3.Name = "novo_orçamento3";
            this.novo_orçamento3.Size = new System.Drawing.Size(190, 46);
            this.novo_orçamento3.TabIndex = 0;
            this.novo_orçamento3.Text = "NOVO ORÇAMENTO";
            this.novo_orçamento3.UseVisualStyleBackColor = false;
            this.novo_orçamento3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.CAD_SERVICO);
            this.tabPage2.Controls.Add(this.CAD_CLIENTE);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CADASTRAR";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // CAD_SERVICO
            // 
            this.CAD_SERVICO.BackColor = System.Drawing.Color.White;
            this.CAD_SERVICO.Location = new System.Drawing.Point(184, 45);
            this.CAD_SERVICO.Name = "CAD_SERVICO";
            this.CAD_SERVICO.Size = new System.Drawing.Size(207, 47);
            this.CAD_SERVICO.TabIndex = 2;
            this.CAD_SERVICO.Text = "SERVIÇO";
            this.CAD_SERVICO.UseVisualStyleBackColor = false;
            this.CAD_SERVICO.Click += new System.EventHandler(this.button8_Click);
            // 
            // CAD_CLIENTE
            // 
            this.CAD_CLIENTE.BackColor = System.Drawing.Color.White;
            this.CAD_CLIENTE.Location = new System.Drawing.Point(184, 98);
            this.CAD_CLIENTE.Name = "CAD_CLIENTE";
            this.CAD_CLIENTE.Size = new System.Drawing.Size(207, 48);
            this.CAD_CLIENTE.TabIndex = 1;
            this.CAD_CLIENTE.Text = "CLIENTE";
            this.CAD_CLIENTE.UseVisualStyleBackColor = false;
            this.CAD_CLIENTE.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CONSULTAR";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(175, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 44);
            this.button7.TabIndex = 1;
            this.button7.Text = "ORÇAMENTOS";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(175, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 45);
            this.button6.TabIndex = 0;
            this.button6.Text = "AGENDA";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button5;
        private Button novo_orçamento3;
        private TabPage tabPage2;
        private Button CAD_SERVICO;
        private Button CAD_CLIENTE;
        private TabPage tabPage3;
        private Button button7;
        private Button button6;
    }
}