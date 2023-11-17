using controle;
using modelo;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FormsApp1
{
    public partial class NOVO_ORÇAMENTO : Form
    {
        cliente_modelo orcamento_porcelanato = new cliente_modelo();
        cliente_controle controle = new cliente_controle();

        private const double dez_porcento = 0.1;
        double sobra = 0;
        int compri = 0, larg = 0;
        float result = 0 ;
        float alt = 0;
        float result1 = 0;
        float result0 = 0;
        float larg_porc = 0 ;
        float larg1 = 0, altura = 0,m_porcelanato = 0;
        float adc_compri = 0, adc_larg = 0;
        float cem = 100, dez = 10, um = 1;
        float rejunte_alt = 0, rejunte_larg = 0, rejunte_v = 0, rejunte_m = 0;
        float expessura = 0, largura_junta = 0, rejunte_result = 0; 
        float rejunte_cr = 0;
        float rejunte_total = 0;
        float argamassa_total = 0;
        float result_nivelador = 0, total_nivelador = 0, total_nivel = 0;
        float alt_decimal = 0, larg_decimal = 0, vezes_decimal = 0;

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

        private void txtresult_m2_TextChanged(object sender, EventArgs e)
        {
            txtresult_m2.Text = Convert.ToString(result);

        }

        private void largura_m2_TextChanged_1(object sender, EventArgs e)
        {
            larg = int.Parse(largura_m2.Text);
            result = (compri * larg);
           
          
         
        }

        private void comprimento_m2_TextChanged_1(object sender, EventArgs e)
        {
            compri = int.Parse(comprimento_m2.Text);
        }

        private void NOME_ARGAMASSA_TextChanged(object sender, EventArgs e)
        {
            string rs = "";
            rs = massa.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text; // selelcionar botão
            NOME_ARGAMASSA.Text = rs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            orcamento_porcelanato.M2 = M2.Text;
            orcamento_porcelanato.txtquant_porcelanato = txtquant_porcelanato.Text;
            orcamento_porcelanato.ARG_TOTAL = ARG_TOTAL.Text;
            orcamento_porcelanato.NOME_ARGAMASSA = NOME_ARGAMASSA.Text;
            orcamento_porcelanato.REJUNTE = REJUNTE.Text;
            orcamento_porcelanato.nivelador_total = nivelador_total.Text;
            orcamento_porcelanato.local_aplicacao = local_aplicacao.Text;
            orcamento_porcelanato.valor_mao_obra = valor_mao_obra.Text;

            controle.cadastrar_orcamento(orcamento_porcelanato);
            MessageBox.Show("Orçamento Salvo com Sucesso");

        }

        private void adc_largura_TextChanged(object sender, EventArgs e)
        {
            adc_larg = float.Parse(adc_largura.Text);
            result1 = (adc_compri * adc_larg);
            result0 = result1 + result;
        }

        private void M2_TextChanged(object sender, EventArgs e)
        {
          //  M2.Text = metros_quadrado.ToString("#,## ", new CultureInfo("pt-BR"));
            M2.Text = result0.ToString("#,## ", new CultureInfo("pt-BR"));
        }

        private void local_aplicacao_TextChanged(object sender, EventArgs e)
        {
                string loc = "";
                loc = LOCAL.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text; // selelcionar botão
                local_aplicacao.Text = loc;

        }

        private void LOCAL_Enter(object sender, EventArgs e)
        {
            
        }

        private void adc_comprimento_TextChanged(object sender, EventArgs e)
        {
            adc_compri = float.Parse(adc_comprimento.Text);
            result1 = (adc_compri * adc_larg);
            result0 = result1 + result;
        }

        private void REJUNTE_TextChanged(object sender, EventArgs e)
        {
            rejunte_cr = Convert.ToInt16(1.62);
            rejunte_larg = larg_porc * dez; // converte em mm
            rejunte_alt = alt * dez; // converte em mm
            rejunte_m = rejunte_larg + rejunte_alt; // A + B (largura + altura em mm)
            rejunte_v = rejunte_alt * rejunte_larg; // A * B (largura * altura em mm)

            rejunte_total = rejunte_m * expessura * largura_junta * rejunte_cr;
            rejunte_result = rejunte_total / rejunte_v;
            rejunte_result = rejunte_result * result;
            
            REJUNTE.Text = rejunte_result.ToString("#,## ", new CultureInfo("pt-BR")) ;
        }

        private void rejunte_profundidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void ARG_TOTAL_TextChanged(object sender, EventArgs e)
        {
            argamassa_total = result / 4;
            ARG_TOTAL.Text = argamassa_total.ToString("#,##", new CultureInfo("pt-BR"));
        }

        private void largura_m2_TextChanged(object sender, EventArgs e)
        {
            larg = int.Parse(largura_m2.Text);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            alt_decimal = alt / cem;// convert decimal
            larg_decimal = larg_porc / cem;//convert decimal
            vezes_decimal = alt_decimal * larg_decimal; //soma nivelador
            result_nivelador = um / vezes_decimal; // soma nivelador
            total_nivelador = result_nivelador * 4; // quantidade de nivelador por m2
            total_nivel = total_nivelador * result;
            nivelador_total.Text = total_nivel.ToString("#,##", new CultureInfo("pt-BR"));


        }

        private void rejunte_expessura_TextChanged(object sender, EventArgs e)
        {
            expessura = int.Parse(rejunte_expessura.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            metros_quadrado.Text = Convert.ToString(result);
        }

        private void largura_m2_Leave(object sender, EventArgs e)
        {
            result = (compri * larg);
            txtresult_m2.Text = Convert.ToString(result);
            metros_quadrado.Text = Convert.ToString(result);
             
        }

        private void quant_porcelanato_TextChanged(object sender, EventArgs e)
        {
            m_porcelanato = altura * larg1; //m² da peça de porcelanato
            double res = result / m_porcelanato;
           
            sobra = dez_porcento * res;
            res = res + sobra;
            txtquant_porcelanato.Text = res.ToString("#,##", new CultureInfo("pt-BR"));
            // txtquant_porcelanato.Text = Convert.ToString(res);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //--------------------------------------------
            float res = result / m_porcelanato;
            largura_junta = int.Parse(rejunte_largura.Text);
            txtquant_porcelanato.Text = res.ToString("#,##", new CultureInfo("pt-BR"));
            nivelador_total.Text = total_nivel.ToString("#,##", new CultureInfo("pt-BR"));
            ARG_TOTAL.Text = argamassa_total.ToString("#,##", new CultureInfo("pt-BR"));
            REJUNTE.Text = rejunte_result.ToString("#,## ", new CultureInfo("pt-BR"));
        }

        private void larg_porcelanato_TextChanged(object sender, EventArgs e)
        {
            larg_porc = float.Parse(larg_porcelanato.Text);
            larg1 = larg_porc / cem; // converte em decimal
        }

        private void alt_porcelanato_TextChanged(object sender, EventArgs e)
        {
            
            alt = float.Parse(alt_porcelanato.Text);
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
