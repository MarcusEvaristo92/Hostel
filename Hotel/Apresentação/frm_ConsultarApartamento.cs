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
    public partial class frm_ConsultarApartamento : Form
    {
        Thread nt;
        public frm_ConsultarApartamento()
        {
            InitializeComponent();
        }

        private void frm_ConsultarApartamento_Load(object sender, EventArgs e)
        {
            dgvApartamento.DataSource = Banco.ObterApartamento();
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

        private void dgvApartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvApartamento_SelectionChanged(object sender, EventArgs e)
        {
           /* DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Banco.ObterDadosApartamento(vid);
                txbId.Text = dt.Rows[0].Field<int>("id").ToString();
                txbNumeroQuarto.Text = dt.Rows[0].Field<Int64>("numeroQuarto").ToString();
                cbTipo.Text = dt.Rows[0].Field<string>("tipo").ToString();
                txbValorDiaria.Text = dt.Rows[0].Field<decimal>("valorDiaria").ToString();
            }
           */
        }
    }
}
