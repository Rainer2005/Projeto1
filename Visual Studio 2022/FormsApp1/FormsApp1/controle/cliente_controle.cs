using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using controle;
using modelo;
using System.Data;

namespace controle
{
    public class cliente_controle
    {
        conexao con = new conexao();
        //criando o metodo de cadastrar usuário
        public bool cadastrar(cliente_modelo cliente)//passo o objeto usuario
        {//declaro a variavel da resposta da query
            bool resultado = false;
            string sql = "insert into cliente(nome,endereço,telefone) " +
                "values ('" + cliente.nome + "','" + cliente.endereco + "' , '" + cliente.telefone + "')";
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }

        public bool cadastrar_orcamento(cliente_modelo orcamento_porcelanato)//passo o objeto usuario
        {//declaro a variavel da resposta da query
            bool resultado = false;
            string sql = "insert into orcamento_porcelanato(M2,txtquant_porcelanato,ARG_TOTAL,NOME_ARGAMASSA,REJUNTE,nivelador_total,local_aplicacao,valor_mao_obra) " +
                "values ('" + orcamento_porcelanato.M2 + "','" + orcamento_porcelanato.txtquant_porcelanato + "' , '" + orcamento_porcelanato.ARG_TOTAL + "' , '" + orcamento_porcelanato.NOME_ARGAMASSA + "' , '"+ orcamento_porcelanato.REJUNTE + "' , '" + orcamento_porcelanato.nivelador_total + "' , '"+ orcamento_porcelanato.local_aplicacao + "' , '"+ orcamento_porcelanato.valor_mao_obra    + "')";
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }







        public bool excluir(int codigo)
        {
            bool resultado = false;
            string sql = "DELETE FROM cliente where id=" + codigo;
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }
        public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool editar(cliente_modelo us)
        {
            bool resultado = false;
            string sql = "update cliente set nome=@nome, telefone=@telefone,endereço=@endereco where id=@id ";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            // substituindo a variavel @___ pelo conteudo do objeto
            command.Parameters.AddWithValue("@nome", us.nome);
            command.Parameters.AddWithValue("@telefone", us.telefone);
            command.Parameters.AddWithValue("@endereco", us.endereco);
            command.Parameters.AddWithValue("@id", us.idusuario);
            if (command.ExecuteNonQuery() >= 1)           
                 resultado = true;                
             sqlcon.Close();                         
            return resultado;
        }
    }
}
