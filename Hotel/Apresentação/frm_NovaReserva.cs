using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frm_NovaReserva : Form
    {
        public frm_NovaReserva()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_NovaReserva_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hostelDataSetHospede.tbHospede'. Você pode movê-la ou removê-la conforme necessário.
            this.tbHospedeTableAdapter.Fill(this.hostelDataSetHospede.tbHospede);

        }
    }
}
