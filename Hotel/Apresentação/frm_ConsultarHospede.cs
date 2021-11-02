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
    public partial class frm_ConsultarHospede : Form
    {
        Thread nt;
        public frm_ConsultarHospede()
        {
            InitializeComponent();
        }

        private void frm_ConsultarHospede_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hostelDataSetHospede.tbHospede'. Você pode movê-la ou removê-la conforme necessário.
            this.tbHospedeTableAdapter.Fill(this.hostelDataSetHospede.tbHospede);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

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
            Application.Run(new frm_MenuPrincipal());
        }
    }
    
}
