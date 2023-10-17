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

namespace FormsApp1
{
    public partial class NOVO_ORÇAMENTO : Form
    {
        public NOVO_ORÇAMENTO()
        {
            InitializeComponent();
        }

        private void NOVO_ORÇAMENTO_Load(object sender, EventArgs e)
        {
            cliente_controle con = new cliente_controle();
            TAMANHO.DataSource = con.obterdados("select *from tamanho");
            TAMANHO.ValueMember = "ID_TAMANHO";
            TAMANHO.DisplayMember = "TAMANHO";
            SERV_ORCAMENTO.DataSource = con.obterdados("select *from serviço ");
            SERV_ORCAMENTO.ValueMember = "ID_SERVICO";
            SERV_ORCAMENTO.DisplayMember = "SERVICO";
        }

        private void SERV_ORCAMENTO_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(SERV_ORCAMENTO != null)
            {
               
            }
        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_m2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comprimento_m2_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
