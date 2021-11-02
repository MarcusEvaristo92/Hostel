using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Hotel.Modelo
{
    class Banco
    {
        private static SqlConnection con;

        private static SqlConnection ConexaoBanco()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-4MOHE5VV\SQLEXPRESS;Initial Catalog=Hostel;Integrated Security=True ");
            return con;
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        //Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public static DataTable ObterApartamento()
        {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var con = ConexaoBanco();
                var cmd = con.CreateCommand();
                cmd.CommandText = " SELECT id, numeroQuarto, tipo, valorDiaria FROM tbApartamento";
                da = new SqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }/*
        public static DataTable ObterDadosApartamento(string id)
        {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var conexao = ConexaoBanco();
                var cmd = conexao.CreateCommand();
                cmd.CommandText = " SELECT * FROM tbApartamento Where id="+id;
                da = new SqlDataAdapter(cmd.CommandText, conexao);
                da.Fill(dt);
                conexao.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }*/
    }
}


