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

    public partial class frm_MenuPrincipal : Form
    {
        Thread nt;

        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarHospede_Click(object sender, EventArgs e)
        {
            nt = new Thread(formCadastrarHospede);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formCadastrarHospede()
        {
            Application.Run(new frm_CadastroHospede());

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            nt = new Thread(formCheckIn);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formCheckIn()
        {
            Application.Run(new frm_CheckIn());
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            nt = new Thread(formCheckOut);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formCheckOut()
        {
            Application.Run(new frm_CheckOut());
        }


        private void btnConsultarHospede_Click(object sender, EventArgs e)
        {
            nt = new Thread(formConsultarHospede);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formConsultarHospede()
        {
            Application.Run(new frm_ConsultarHospede());
        }

        private void btnNovaReserva_Click(object sender, EventArgs e)
        {
            nt = new Thread(formNovaReserva);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formNovaReserva()
        {
            Application.Run(new frm_NovaReserva());
        }

        private void btnConsultaReserva_Click(object sender, EventArgs e)
        {
            nt = new Thread(formConsultarReserva);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formConsultarReserva()
        {
            Application.Run(new frm_ConsultarReserva());
        }

        private void btnMapaHospedagem_Click(object sender, EventArgs e)
        {
            nt = new Thread(formMapaHospedagem);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formMapaHospedagem()
        {
            Application.Run(new frm_MapaHospedagem());
        }


        private void btnConsultarApartamento_Click(object sender, EventArgs e)
        {
            nt = new Thread(formConsultarApartamento);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formConsultarApartamento()
        {
            Application.Run(new frm_ConsultarApartamento());
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            nt = new Thread(formDesconectar);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void formDesconectar()
        {
            Application.Run(new frm_Login());
        }

        private void btnCadastrarApartamento_Click_1(object sender, EventArgs e)
        {
            nt = new Thread(formCadastrarAp);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void formCadastrarAp()
        {
            Application.Run(new frm_CadastroAp());
        }
    }
}

