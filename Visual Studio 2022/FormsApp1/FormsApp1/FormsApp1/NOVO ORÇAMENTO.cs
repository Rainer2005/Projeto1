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
        int compri = 0, larg = 0;
        float result = 0 ;
        int alt = 0, larg_porc = 0 ;
        float larg1 = 0, altura = 0,m_porcelanato = 0;
        float cem = 100, dez = 10;
        float rejunte_alt = 0, rejunte_larg = 0, rejunte_v = 0, rejunte_m = 0;
        float expessura = 0, largura_junta = 0, profundidade = 0, rejunte_result = 0; 
        double rejunte_cr = 1.62;
        float rejunte_total = 0;




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

        private void REJUNTE_TextChanged(object sender, EventArgs e)
        {
            rejunte_larg = larg_porc * dez; // converte em mm
            rejunte_alt = alt * dez; // converte em mm
            rejunte_m = rejunte_larg + rejunte_alt; // A + B (largura + altura em mm)
            rejunte_v = rejunte_alt * rejunte_larg; // A * B (largura * altura em mm)

            rejunte_total = rejunte_m * rejunte_expessura * rejunte_profundidade * rejunte_cr;
            rejunte_result = rejunte_total / rejunte_v; 
        }

        private void rejunte_profundidade_TextChanged(object sender, EventArgs e)
        {
            profundidade = int.Parse(rejunte_profundidade.Text);
        }

        private void largura_m2_TextChanged(object sender, EventArgs e)
        {
            larg = int.Parse(largura_m2.Text);
        }

        private void rejunte_expessura_TextChanged(object sender, EventArgs e)
        {
            expessura = int.Parse(rejunte_expessura.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void largura_m2_Leave(object sender, EventArgs e)
        {
             result = (compri * larg);
          // result = m_porcelanato; // teste 
            txtresult_m2.Text = Convert.ToString(result);
            textBox2.Text = Convert.ToString(result);
             
        }

        private void quant_porcelanato_TextChanged(object sender, EventArgs e)
        {
            m_porcelanato = altura * larg1; //m² da peça de porcelanato
            float res = result / m_porcelanato;
            txtquant_porcelanato.Text = Convert.ToString(res);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            largura_junta = int.Parse(rejunte_largura.Text);
        }

        private void larg_porcelanato_TextChanged(object sender, EventArgs e)
        {
            larg_porc = int.Parse(larg_porcelanato.Text);
            larg1 = larg_porc / cem; // converte em decimal
        }

        private void alt_porcelanato_TextChanged(object sender, EventArgs e)
        {
            alt = int.Parse(alt_porcelanato.Text);
            altura = alt / cem; //convert em decimal
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
