using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Modelo;

namespace Hotel.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool temAp;
        public String mensagemCadAp = "";


        public bool acessar(String usuario, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(usuario, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
             
            }
            return tem;
        }
        public String cadastrar(String nome, String cargo, String cpf, String rg, String endereco, String numero, String telefone, String usuario, String senha, String confirmarSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            mensagem = loginDao.cadastrar(nome, cargo, cpf, rg, endereco, numero, telefone, usuario, senha, confirmarSenha);
            if (loginDao.tem)// a mensagem que vai vir 
            {
                this.tem = true;
            }
            return mensagem;
        }
       

    }
}
