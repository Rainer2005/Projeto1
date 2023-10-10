namespace FormsApp1
{
    partial class CLIENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENTE));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.SALVAR_CLIENTE = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_CODIGO = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME DO CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NÚMERO DO CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ENDEREÇO DO CLIENTE";
            // 
            // nome
            // 
            this.nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nome.Location = new System.Drawing.Point(326, 112);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(333, 23);
            this.nome.TabIndex = 3;
            // 
            // numero
            // 
            this.numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numero.Location = new System.Drawing.Point(326, 146);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(333, 23);
            this.numero.TabIndex = 4;
            // 
            // endereco
            // 
            this.endereco.BackColor = System.Drawing.Color.White;
            this.endereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.endereco.ForeColor = System.Drawing.SystemColors.InfoText;
            this.endereco.Location = new System.Drawing.Point(326, 174);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(333, 23);
            this.endereco.TabIndex = 5;
            // 
            // SALVAR_CLIENTE
            // 
            this.SALVAR_CLIENTE.BackColor = System.Drawing.Color.White;
            this.SALVAR_CLIENTE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SALVAR_CLIENTE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SALVAR_CLIENTE.Location = new System.Drawing.Point(594, 407);
            this.SALVAR_CLIENTE.Name = "SALVAR_CLIENTE";
            this.SALVAR_CLIENTE.Size = new System.Drawing.Size(65, 31);
            this.SALVAR_CLIENTE.TabIndex = 6;
            this.SALVAR_CLIENTE.Text = "SALVAR";
            this.SALVAR_CLIENTE.UseVisualStyleBackColor = false;
            this.SALVAR_CLIENTE.Click += new System.EventHandler(this.button1_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.White;
            this.editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editar.Location = new System.Drawing.Point(665, 407);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(55, 31);
            this.editar.TabIndex = 7;
            this.editar.Text = "EDITAR";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(726, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "EXCLUIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID CLIENTE";
            // 
            // TXT_CODIGO
            // 
            this.TXT_CODIGO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_CODIGO.Location = new System.Drawing.Point(326, 83);
            this.TXT_CODIGO.Name = "TXT_CODIGO";
            this.TXT_CODIGO.Size = new System.Drawing.Size(333, 23);
            this.TXT_CODIGO.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(491, 125);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXT_CODIGO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.SALVAR_CLIENTE);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CLIENTE";
            this.Text = "CLIENTE";
            this.Load += new System.EventHandler(this.CLIENTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nome;
        private TextBox numero;
        private TextBox endereco;
        private Button SALVAR_CLIENTE;
        private Button editar;
        private Button button3;
        private Label label4;
        private TextBox TXT_CODIGO;
        private DataGridView dataGridView1;
    }
}