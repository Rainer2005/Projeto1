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
    public partial class ORCAMENTO : Form
    {
        float comprimento1 = 0, largura1 = 0, resultado1 = 0; // metros² calculo
        float alturap1 = 0, largurap1 = 0, resultadop1 = 0; // tamanho porcelanato



        public ORCAMENTO()
        {
            InitializeComponent();
        }

        private void comprimento_TextChanged(object sender, EventArgs e)
        {
            comprimento1 = float.Parse(comprimento.Text);
           // resultado1 = comprimento1 * largura1;
           // resultadom2.Text = Convert.ToString(resultado1);
        }

        private void largura_TextChanged(object sender, EventArgs e)
        {
            largura1 = float.Parse(largura.Text);
          //  resultado1 = comprimento1 * largura1;
          //  resultadom2.Text = Convert.ToString(resultado1);
        }

        private void altura_peca_TextChanged(object sender, EventArgs e)
        {
            alturap1 = float.Parse(altura_peca.Text);
        }

        private void largura_peca_TextChanged(object sender, EventArgs e)
        {
            largurap1 = float.Parse(largura_peca.Text);
        }

        private void resultadom2_TextChanged(object sender, EventArgs e)
        {
            resultado1 = comprimento1 * largura1;
            resultadom2.Text = Convert.ToString(resultado1);
        }

        private void local_aplicacao_Enter(object sender, EventArgs e)
        {
           // string loc = "";
           // loc = LOCAL.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text; // selelcionar botão
           // local_aplicacao.Text = loc;
        }


        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
