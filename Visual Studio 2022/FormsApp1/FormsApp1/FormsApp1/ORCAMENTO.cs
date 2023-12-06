using Microsoft.VisualBasic.Logging;
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
using controle;
using modelo;

namespace FormsApp1
{

  

    public partial class ORCAMENTO : Form
    {
        float alt_decimal = 0, larg_decimal = 0, vezes_decimal = 0, result_nivelador = 0, total_nivelador = 0,total_nivel = 0;
        float comprimento1 = 0, largura1 = 0, resultado1 = 0; // metros² calculo
        float alturap1 = 0, largurap1 = 0, resultadop1 = 0, altura_porc = 0, larg_porc = 0; // tamanho porcelanato
        float espressura = 0, larg_junta = 0,resultado_rj = 0, resultado_rejunte = 0, resultado_rejunte1 =0,resultado_rejunte2 = 0, resultado_rejunte3 = 0, cr = 0 ,altura_somar = 0, largura_somar = 0; // calculo rejunte
        float dez = 10, cem = 100, um = 1;

        cliente_modelo orcamento_porcelanato = new cliente_modelo();
        cliente_controle con = new cliente_controle();
        private void ORCAMENTO_Load(object sender, EventArgs e)
        {
            
        }

        private void tela_nivelador_TextChanged(object sender, EventArgs e)
        {
            
            alt_decimal = alturap1 / cem;// convert decimal
            larg_decimal = largurap1 / cem;//convert decimal
            vezes_decimal = alt_decimal * larg_decimal; //soma nivelador
            result_nivelador = um / vezes_decimal; // soma nivelador
            total_nivelador = result_nivelador * 4; // quantidade de nivelador por m2
            total_nivel = total_nivelador * resultado1;
            tela_nivelador.Text = total_nivel.ToString("#,##", new CultureInfo("pt-BR"));
            
        }

        private void tela_argamassa_TextChanged(object sender, EventArgs e)
        {
            tela_argamassa.Text = Convert.ToString(resultado1 / 4);
        }

        private void SALVAR_Click_1(object sender, EventArgs e)
        {

            orcamento_porcelanato.tela_m2 = tela_m2.Text;
            orcamento_porcelanato.tela_porcelanato = tela_porcelanato.Text;
            orcamento_porcelanato.tela_argamassa = tela_argamassa.Text;
            orcamento_porcelanato.tela_tipoarg = tela_tipoarg.Text;
            orcamento_porcelanato.tela_rejunte = tela_rejunte.Text;
            orcamento_porcelanato.tela_nivelador = tela_nivelador.Text;
            orcamento_porcelanato.local_apli = local_apli.Text;
            orcamento_porcelanato.tela_valor_total = tela_valor_total.Text;

            con.cadastrar_orcamento(orcamento_porcelanato);
            MessageBox.Show("Orçamento Salvo com Sucesso");

        }

        public ORCAMENTO()
        {
            InitializeComponent();
        }

        private void altura_peca_TextChanged(object sender, EventArgs e)
        {
            alturap1 = float.Parse(altura_peca.Text);
        }

        private void tela_tipoarg_TextChanged(object sender, EventArgs e)
        {
            string tip = "";
            tip = arg_table.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text; // selelcionar botão
            tela_tipoarg.Text = tip;
        }


        private void resultadom2_TextChanged_1(object sender, EventArgs e) // somando quantos metros²
        {
            resultado1 = comprimento1 * largura1;
            resultadom2.Text = Convert.ToString(resultado1);
            tela_m2.Text = Convert.ToString(resultado1);
            m2.Text = Convert.ToString(resultado1);
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
            altura_porc = alturap1 / cem;
        }

        private void tela_porcelanato_TextChanged(object sender, EventArgs e) // quantidade de porcelnato
        {
            resultadop1 = altura_porc * larg_porc;
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
            altura_somar = alturap1 * dez;
            largura_somar = largurap1 * dez;
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
            larg_porc = largurap1 / cem;
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
