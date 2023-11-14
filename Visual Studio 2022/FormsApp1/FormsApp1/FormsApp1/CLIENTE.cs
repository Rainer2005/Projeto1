using controle;
using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class CLIENTE : Form
    {
        int codigo;
        cliente_modelo cliente = new cliente_modelo(); 
        cliente_controle controle = new cliente_controle();
       
        public CLIENTE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            cliente.nome = nome.Text;
            cliente.telefone = numero.Text;
            cliente.endereco = endereco.Text;
           
            controle.cadastrar(cliente);
            MessageBox.Show("Cliente Salvo com Sucesso");

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            controle.excluir(Convert.ToInt32 (TXT_CODIGO.Text));
        }

        private void CLIENTE_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.obterdados("select *from cliente");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            MessageBox.Show("Codigo " + codigo.ToString());
            nome.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            endereco.Text = dataGridView1.Rows[e.RowIndex].Cells["endereço"].Value.ToString();
            numero.Text = dataGridView1.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            TXT_CODIGO.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente.idusuario = Convert.ToInt32(TXT_CODIGO.Text);

            cliente.nome = nome.Text;
            cliente.telefone = numero.Text;
            cliente.endereco = endereco.Text;
            controle.editar(cliente);
            MessageBox.Show("Cliente editado com Sucesso");
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
