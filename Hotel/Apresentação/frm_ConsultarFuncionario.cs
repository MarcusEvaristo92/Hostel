using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Hotel.Modelo;

namespace Hotel
{
    public partial class frm_ConsultarFuncionario : Form
    {
        Thread nt;
        Conexao conexao = new Conexao();


        public frm_ConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void frm_ConsultarFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hostelDataSetFuncionario.cadastroFuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroFuncionarioTableAdapter.Fill(this.hostelDataSetFuncionario.cadastroFuncionario);
            dgvConsultarFuncionario.Columns[0].Width = 60;
            dgvConsultarFuncionario.Columns[1].Width = 180;
            dgvConsultarFuncionario.Columns[2].Width = 100;

        }

        private void dgvConsultarFuncionario_SelectionChanged(object sender, EventArgs e)
        {
            /*DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Banco.ObterDadosFuncionario(vid);
                txbId.Text = dt.Rows[0].Field<int>("id").ToString();
          */
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
    }
}
   
    