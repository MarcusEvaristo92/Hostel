using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public class CadastroHospedeDaoComando
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagemCadHosp;

        public CadastroHospedeDaoComando(String nome, String cpf, String rg, String cidade, String endereco, String numero, String dataNascimento, String telefone)
        {
            //Comando Sql
            cmd.CommandText = "USE Hostel; " +
                "INSERT INTO tbHospede(nome, cpf, rg, cidade, endereco, numero, dataNascimento, telefone) values(@nome, @cpf, @rg, @cidade, @endereco, @numero, @dataNascimento, @telefone);";

            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();

                //Executar Comando
                cmd.ExecuteNonQuery();

                //desconectar com banco
                conexao.desconectar();

                //mostrar mensagem de erro ou sucesso
                this.mensagemCadHosp = "Cadastro com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagemCadHosp = "Erro ao se conectar com o banco de dados!!";
            }
        }
    } 
}
