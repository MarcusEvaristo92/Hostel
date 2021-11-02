using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Hotel.Modelo;
using Hotel.DAL;

namespace Hotel
{
    public class CadastroApartamento
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagemCadAp;

        public CadastroApartamento(String numeroQuarto, String tipo, String valorDiaria)
        {
            cmd.CommandText = "INSERT INTO tbApartamento(numeroQuarto, tipo, valorDiaria) values(@numeroQuarto, tipo, valorDiaria)";

            cmd.Parameters.AddWithValue("numeroQuarto",numeroQuarto);
            cmd.Parameters.AddWithValue("tipo", tipo);
            cmd.Parameters.AddWithValue("valorDiaria", valorDiaria);

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar comando BD
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                this.mensagemCadAp = "Cadastrado com Sucesso!";
            }
            catch(Exception)
            {
                this.mensagemCadAp = "Erro ao se conectar com o banco de dados!";
            }
        }
       
    }
}
