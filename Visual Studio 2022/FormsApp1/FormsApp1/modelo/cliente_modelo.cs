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
        public string tela_m2;
        public string tela_porcelanato;
        public string tela_argamassa;
        public string tela_tipoarg;
        public string tela_rejunte;
        public string tela_nivelador;
        public string local_apli;
        public string tela_valor_total;

        // serviço
        public string servico;
        public string valor_metros2;


        //construtor da classe modelo usuario
        public cliente_modelo()
        {
            // CLIENTE
            nome = null;
            endereco = null;
            telefone = null;//inicializo com 0      

            // ORCAMENTO PORCELANATO
            tela_m2 = null;
            tela_porcelanato = null;
            tela_argamassa = null;
            tela_tipoarg = null;
            tela_rejunte = null;
            tela_nivelador = null;
            local_apli = null;
            tela_valor_total = null;

            //servico
            servico = null;
            valor_metros2 = null;
    }
    }
}
