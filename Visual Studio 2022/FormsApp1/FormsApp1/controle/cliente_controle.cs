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
            string sql = "insert into orcamento_porcelanato(tela_m2,tela_porcelanato,tela_argamassa,tela_tipoarg,tela_rejunte,tela_nivelador,local_apli,tela_valor_total) " +
                "values ('" + orcamento_porcelanato.tela_m2 + "','" + orcamento_porcelanato.tela_porcelanato + "' , '" + orcamento_porcelanato.tela_argamassa + "' , '" + orcamento_porcelanato.tela_tipoarg + "' , '"+ orcamento_porcelanato.tela_rejunte + "' , '" + orcamento_porcelanato.tela_nivelador + "' , '"+ orcamento_porcelanato.local_apli + "' , '"+ orcamento_porcelanato.tela_valor_total + "')";
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }

        public bool cadastrar_servico(cliente_modelo servico)//passo o objeto usuario
        {//declaro a variavel da resposta da query
            bool resultado = false;
            string sql = "insert into orcamento_porcelanato(servico,valor_metros2) " +
                "values ('" + servico.tela_m2 + "','" + servico.valor_metros2 + "')";
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
