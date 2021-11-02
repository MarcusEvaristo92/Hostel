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

namespace Hotel
{
   
    public partial class frm_CadastroHospede : Form
    {
        Thread nt;

        public frm_CadastroHospede()
        {
            InitializeComponent();
        }

        private void btnCadastrarHospede_Click(object sender, EventArgs e)
        {
            CadastroHospedeDaoComando cadHosp = new CadastroHospedeDaoComando (txbNome.Text, txbCpf.Text, txbRg.Text, txbCidade.Text,
                txbEndereco.Text, txbNumero.Text, dtpDataNascimeto.Text, txbTelefone.Text);
            MessageBox.Show(cadHosp.mensagemCadHosp);
            txbNome.Clear();
            txbCpf.Clear();
            txbRg.Clear();
            txbCidade.Clear();
            txbEndereco.Clear();
            txbNumero.Clear();
            txbTelefone.Clear();
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            nt = new Thread(menuPrincipal);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();

        }

        private void menuPrincipal()
        {
            Application.Run(new frm_MenuPrincipal());
        }
    }
}
