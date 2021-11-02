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
    public partial class frm_CadastroAp : Form
    {
       
        public frm_CadastroAp()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroApartamento cadAp = new CadastroApartamento(txbNumeroQuarto.Text, cbTipo.Text, txbValorDiaria.Text);
            MessageBox.Show(cadAp.mensagemCadAp);
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.Run();
        }
    }
    
}
