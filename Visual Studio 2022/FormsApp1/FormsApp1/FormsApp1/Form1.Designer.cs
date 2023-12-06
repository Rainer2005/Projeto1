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
            this.novo_orçamento3 = new System.Windows.Forms.Button();
            this.CAD_SERVICO = new System.Windows.Forms.Button();
            this.CAD_CLIENTE = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.coluna2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.coluna2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // novo_orçamento3
            // 
            this.novo_orçamento3.BackColor = System.Drawing.Color.White;
            this.novo_orçamento3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.novo_orçamento3.Location = new System.Drawing.Point(1, 1);
            this.novo_orçamento3.Margin = new System.Windows.Forms.Padding(0);
            this.novo_orçamento3.Name = "novo_orçamento3";
            this.novo_orçamento3.Size = new System.Drawing.Size(148, 57);
            this.novo_orçamento3.TabIndex = 0;
            this.novo_orçamento3.Text = "NOVO ORÇAMENTO";
            this.novo_orçamento3.UseVisualStyleBackColor = false;
            this.novo_orçamento3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CAD_SERVICO
            // 
            this.CAD_SERVICO.BackColor = System.Drawing.Color.White;
            this.CAD_SERVICO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CAD_SERVICO.Location = new System.Drawing.Point(1, 175);
            this.CAD_SERVICO.Margin = new System.Windows.Forms.Padding(0);
            this.CAD_SERVICO.Name = "CAD_SERVICO";
            this.CAD_SERVICO.Size = new System.Drawing.Size(148, 57);
            this.CAD_SERVICO.TabIndex = 2;
            this.CAD_SERVICO.Text = "SERVIÇO";
            this.CAD_SERVICO.UseVisualStyleBackColor = false;
            this.CAD_SERVICO.Click += new System.EventHandler(this.button8_Click);
            // 
            // CAD_CLIENTE
            // 
            this.CAD_CLIENTE.BackColor = System.Drawing.Color.White;
            this.CAD_CLIENTE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CAD_CLIENTE.Location = new System.Drawing.Point(1, 117);
            this.CAD_CLIENTE.Margin = new System.Windows.Forms.Padding(0);
            this.CAD_CLIENTE.Name = "CAD_CLIENTE";
            this.CAD_CLIENTE.Size = new System.Drawing.Size(148, 57);
            this.CAD_CLIENTE.TabIndex = 1;
            this.CAD_CLIENTE.Text = "CLIENTE";
            this.CAD_CLIENTE.UseVisualStyleBackColor = false;
            this.CAD_CLIENTE.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.coluna2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 667);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // coluna2
            // 
            this.coluna2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.coluna2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.coluna2.ColumnCount = 2;
            this.coluna2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.coluna2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.coluna2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.coluna2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coluna2.Location = new System.Drawing.Point(1, 77);
            this.coluna2.Margin = new System.Windows.Forms.Padding(0);
            this.coluna2.Name = "coluna2";
            this.coluna2.RowCount = 1;
            this.coluna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.coluna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.coluna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.coluna2.Size = new System.Drawing.Size(973, 589);
            this.coluna2.TabIndex = 0;
            this.coluna2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.CAD_SERVICO, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.CAD_CLIENTE, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.novo_orçamento3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(150, 585);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(1, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "ORÇAMENTO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 667);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.coluna2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button novo_orçamento3;
        private Button CAD_SERVICO;
        private Button CAD_CLIENTE;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel coluna2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
    }
}