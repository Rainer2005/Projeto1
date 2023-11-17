using controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using controle;

namespace FormsApp1
{
    public partial class FRM_SERVICO : Form
    {
        public FRM_SERVICO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MATERIAL_Load(object sender, EventArgs e)
        {
            cliente_controle con = new cliente_controle();
            SERVICO.DataSource = con.obterdados("select *from serviço ");
            SERVICO.ValueMember = "ID_SERVICO";
            SERVICO.DisplayMember = "SERVICO";

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void salvar_servico_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
