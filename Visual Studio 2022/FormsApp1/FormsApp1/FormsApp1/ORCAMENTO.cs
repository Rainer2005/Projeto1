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

namespace FormsApp1
{
    public partial class ORCAMENTO : Form
    {
        float comprimento1 = 0, largura1 = 0, resultado1 = 0; // metros² calculo
        float alturap1 = 0, largurap1 = 0, resultadop1 = 0; // tamanho porcelanato
        float espressura = 0, larg_junta = 0,resultado_rj = 0, resultado_rejunte = 0, resultado_rejunte1 =0,resultado_rejunte2 = 0, resultado_rejunte3 = 0, cr = 0 ,altura_somar = 0, largura_somar = 0; // calculo rejunte



        public ORCAMENTO()
        {
            InitializeComponent();
        }

        private void altura_peca_TextChanged(object sender, EventArgs e)
        {
            alturap1 = float.Parse(altura_peca.Text);
        }

        private void SALVAR_Click(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void resultadom2_TextChanged_1(object sender, EventArgs e) // somando quantos metros²
        {
            resultado1 = comprimento1 * largura1;
            resultadom2.Text = Convert.ToString(resultado1);
            tela_m2.Text = Convert.ToString(resultado1);
        }

        private void largura_TextChanged_1(object sender, EventArgs e) // largura metros²
        {
            largura1 = float.Parse(largura.Text);
        }

        private void local_apli_TextChanged(object sender, EventArgs e) // local aplicação radio button
        {
           string loc = "";
           loc = tabela_aplicacao.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text; // selelcionar botão
           local_apli.Text = loc;
        }

        private void alt_peca_TextChanged(object sender, EventArgs e) // altura da peça
        {
            alturap1 = float.Parse(alt_peca.Text);
            alturap1 = alturap1 / 100;
        }

        private void tela_porcelanato_TextChanged(object sender, EventArgs e) // quantidade de porcelnato
        {
            resultadop1 = alturap1 * largurap1;
            resultadop1 = resultado1 / resultadop1;
            tela_porcelanato.Text = Convert.ToString(resultadop1);
        }

        private void lar_junta_TextChanged(object sender, EventArgs e)
        {
            larg_junta = float.Parse(lar_junta.Text);
        }

        private void tela_rejunte_TextChanged(object sender, EventArgs e)
        {
            cr = Convert.ToInt16(1.62);
            altura_somar = alturap1 * 10;
            largura_somar = largurap1 * 10;
            resultado_rejunte1 = altura_somar + largura_somar;
            resultado_rejunte2 = altura_somar * largura_somar;

            resultado_rejunte3 = resultado_rejunte1 * espressura * larg_junta * cr;
            resultado_rj = resultado_rejunte3 / resultado_rejunte2;
            resultado_rejunte = resultado_rj * resultado1;

            tela_rejunte.Text = resultado_rejunte.ToString("#,## ", new CultureInfo("pt-BR"));
        }

        private void esp_peca_TextChanged(object sender, EventArgs e)
        {
            espressura = float.Parse(esp_peca.Text);
        }

        private void larg_peca_TextChanged(object sender, EventArgs e) // largura da peça
        {
            largurap1 = float.Parse(larg_peca.Text);
            largurap1 = largurap1 / 100;
        }

        private void comprimento_TextChanged_1(object sender, EventArgs e) // comprimento metros²
        {
            comprimento1 = float.Parse(comprimento.Text);
        }
       

        private void local_aplicacao_Enter(object sender, EventArgs e)
        {
  
        }


        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
