using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel
{
    public class ConsultaHospede
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public ConsultaHospede(String nome, String cpf, String rg, String cidade, String endereco, String numero, String dataNascimento, String telefone)
        {
            //Comando Sql
            cmd.CommandText = "USE Hostel; " +
                "Select nome,cpf from(numeroQuarto, tipo, valorDiaria, descricao) values(@numeroQuarto, @tipo, @valorDiaria, @descricao);";


            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();

                //Executar Comando
                cmd.ExecuteNonQuery();

                //desconectar com banco
                conexao.desconectar();

                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastro com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados!";
            }
        }
    }
}
        
    

