using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Hotel.Modelo;
using Hotel.DAL;

namespace Hotel
{
    public partial class frm_Login : Form
    { 
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbUsuario.Text, txbSenha.Text);
             if (controle.mensagem.Equals(""))
             {
                 if (controle.tem)
                    {
                        MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_MenuPrincipal menuPrincipal = new frm_MenuPrincipal();
                        menuPrincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorretos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
             }
             else
             {
                MessageBox.Show(controle.mensagem);
            }
        }
        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSenha_Click(object sender, EventArgs e)
        {

        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
