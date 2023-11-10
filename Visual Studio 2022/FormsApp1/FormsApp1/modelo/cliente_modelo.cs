using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class cliente_modelo
    {

        // CLIENTE
        public int idusuario;
        public string nome;
        public string telefone;
        public string endereco;//inclui o perfil usuario

        // ORCAMENTO PORCELANATO
        public string M2;
        public string txtquant_porcelanato;
        public string ARG_TOTAL;
        public string NOME_ARGAMASSA;
        public string REJUNTE;
        public string nivelador_total;
        public string local_aplicacao;
        public string valor_mao_obra;


        //construtor da classe modelo usuario
        public cliente_modelo()
        {
            // CLIENTE
            nome = null;
            endereco = null;
            telefone = null;//inicializo com 0      
            // ORCAMENTO PORCELANATO
            M2 = "";
            txtquant_porcelanato = "";
            ARG_TOTAL = "";
            NOME_ARGAMASSA = "";
            REJUNTE = "";
            nivelador_total = "";
            local_aplicacao = "";
            valor_mao_obra = "";
    }
    }
}
