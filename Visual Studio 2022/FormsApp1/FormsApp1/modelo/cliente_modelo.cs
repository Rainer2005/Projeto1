using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class cliente_modelo
    {
        public int idusuario;
        public string nome;
        public string telefone;
        public string endereco;//inclui o perfil usuario
        
        //construtor da classe modelo usuario
        public cliente_modelo()
        {
            nome = null;
            endereco = null;
            telefone = null;//inicializo com 0      
        }
    }
}
