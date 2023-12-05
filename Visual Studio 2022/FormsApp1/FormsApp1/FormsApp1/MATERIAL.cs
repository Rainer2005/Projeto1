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

    cliente_modelo servico = new cliente_modelo();
    cliente_controle con = new cliente_controle();

        string servico1 = "";
        float valor = 0;

        public FRM_SERVICO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MATERIAL_Load(object sender, EventArgs e)
        {
           // cliente_controle con = new cliente_controle();
           // SERVICO.DataSource = con.obterdados("select *from serviço ");
           // SERVICO.ValueMember = "ID_SERVICO";
           // SERVICO.DisplayMember = "SERVICO";

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void salvar_servico_Click(object sender, EventArgs e)
        {
            servico = servico1;
            servico.servico = Convert.ToInt16(servico);
            servico.valor = Convert.ToString(valor);

            con.cadastrar_orcamento(servico);
            MessageBox.Show("Orçamento Salvo com Sucesso");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastro_servico_Enter(object sender, EventArgs e)
        {
            string serv = "";
            serv = cadastro_servico.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text; // selelcionar botão
            servico1 = serv;

        }

        private void teste1_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void valor_m2_TextChanged(object sender, EventArgs e)
        {
            valor = float.Parse(valor_m2.Text);
        }
    }
}
