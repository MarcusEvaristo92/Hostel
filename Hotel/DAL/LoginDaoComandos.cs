using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

            public bool verificarLogin(String usuario, String senha)
            {
                //comandos Sql -- procurar no banco esse usuario e senha
                cmd.CommandText = " select * from cadastroFuncionario where usuario = @usuario and senha = @senha";
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                //conectar com banco
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                
                    if (dr.HasRows)//Se foi encontrado
                    {
                        tem = true;
                    }                    
                    //desconectar com banco
                    con.desconectar();
                    dr.Close();

                
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados!";
            }
            return tem;
    }


    public String cadastrar(String nome, String cargo, String cpf, String rg,String endereco, String numero, String telefone, String usuario, String senha, String confirmarSenha)
    {
        tem = false;
        //comandos para inserir
        if (senha.Equals(confirmarSenha))
        {
            cmd.CommandText = "USE Hostel;" +
                "INSERT INTO cadastrofuncionario(nome, cargo, cpf, rg, endereco, numero, telefone, usuario, senha) VALUES (@nome, @cargo, @cpf, @rg, @endereco, @numero,@telefone, @usuario, @senha);";

            cmd.Parameters.AddWithValue("nome",nome);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@rg" , rg);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
          

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
        }
        else
        {
            this.mensagem = "Senhas não correspondem!";
        }
        return mensagem;

    }
    }
    }

