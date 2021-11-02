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

namespace Hotel
{
    public partial class frm_CadastroFuncionario : Form
    {
        Thread nt;
        public frm_CadastroFuncionario()
        {

            InitializeComponent();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void novoForm()
        {
            Application.Run(new frm_Principal());
        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }
        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txbNome.Text, cbCargo.Text, txbCpf.Text, txbRg.Text, txbEndereco.Text, txbNumero.Text, txbTelefone.Text, txbUsuario.Text, txbSenha.Text, txbConfirmarSenha.Text);
         
            if (controle.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNome.Clear();
                txbCpf.Clear();
                txbRg.Clear();
                txbEndereco.Clear();
                txbNumero.Clear();
                txbTelefone.Clear();
                txbUsuario.Clear();
                txbSenha.Clear();
                txbConfirmarSenha.Clear();
            }
            else
            {
                MessageBox.Show(controle.mensagem); //mensagem de erro
                txbSenha.Clear();
                txbConfirmarSenha.Clear();
            }
        }
    }
}

