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
        int compri = 0, larg = 0, result = 0;
        int alt = 0, comp = 0, alt1 = 0, larg1 = 0,m_porcelanato = 0;

        public NOVO_ORÇAMENTO()
        {
            InitializeComponent();
        }

        private void NOVO_ORÇAMENTO_Load(object sender, EventArgs e)
        {
            cliente_controle con = new cliente_controle();
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

        private void largura_m2_TextChanged(object sender, EventArgs e)
        {
            larg = int.Parse(largura_m2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void largura_m2_Leave(object sender, EventArgs e)
        {
            result = (compri * larg);
            txtresult_m2.Text = Convert.ToString(result);
            textBox2.Text = Convert.ToString(result);
           
        }

        private void quant_porcelanato_TextChanged(object sender, EventArgs e)
        {
            m_porcelanato = alt1 * larg1; //m² da peça de porcelanato
           quant_porcelanato.Text = Convert.ToString (result / m_porcelanato);
        }

        private void larg_porcelanato_TextChanged(object sender, EventArgs e)
        {
            larg = int.Parse(larg_porcelanato.Text);
            larg1 = larg / 100; // converte em decimal
        }

        private void alt_porcelanato_TextChanged(object sender, EventArgs e)
        {
            alt = int.Parse(alt_porcelanato.Text);
            alt1 = alt / 100; //convert em decimal
        }

        private void result_m2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comprimento_m2_TextChanged(object sender, EventArgs e)
        {
            compri = int.Parse(comprimento_m2.Text);

        }
    }
}
