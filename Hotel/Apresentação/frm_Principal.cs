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
    public partial class frm_Principal : Form
    {
        Thread nt;
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void novoForm()
        {
            Application.Run(new frm_CadastroFuncionario());
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            nt = new Thread(formConsultaFuncionario);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void formConsultaFuncionario()
        {
            Application.Run(new frm_ConsultarFuncionario());
        }

        private void button4_Click(object sender, EventArgs e)
        {
                    }
    }
    
}
