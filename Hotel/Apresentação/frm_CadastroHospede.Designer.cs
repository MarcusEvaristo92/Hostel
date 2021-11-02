
namespace Hotel
{
    partial class frm_CadastroHospede
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroHospede));
            this.btnCadastrarHospede = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCadastrarHospede = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblQuartoPreferido = new System.Windows.Forms.Label();
            this.dtpDataNascimeto = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbRg = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarHospede
            // 
            this.btnCadastrarHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarHospede.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarHospede.Location = new System.Drawing.Point(135, 465);
            this.btnCadastrarHospede.Name = "btnCadastrarHospede";
            this.btnCadastrarHospede.Size = new System.Drawing.Size(171, 71);
            this.btnCadastrarHospede.TabIndex = 0;
            this.btnCadastrarHospede.Text = "Cadastrar";
            this.btnCadastrarHospede.UseVisualStyleBackColor = true;
            this.btnCadastrarHospede.Click += new System.EventHandler(this.btnCadastrarHospede_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 148);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(12, 194);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 19);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "Cpf:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(171, 139);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(391, 27);
            this.txbNome.TabIndex = 3;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(12, 237);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 19);
            this.lblRg.TabIndex = 5;
            this.lblRg.Text = "Rg:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(503, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lblCadastrarHospede
            // 
            this.lblCadastrarHospede.AutoSize = true;
            this.lblCadastrarHospede.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCadastrarHospede.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarHospede.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCadastrarHospede.Location = new System.Drawing.Point(23, 34);
            this.lblCadastrarHospede.Name = "lblCadastrarHospede";
            this.lblCadastrarHospede.Size = new System.Drawing.Size(272, 33);
            this.lblCadastrarHospede.TabIndex = 8;
            this.lblCadastrarHospede.Text = "Cadastrar Hóspede";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(12, 281);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(66, 19);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 326);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(85, 19);
            this.lblEndereco.TabIndex = 10;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txbCidade
            // 
            this.txbCidade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCidade.Location = new System.Drawing.Point(171, 272);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(344, 27);
            this.txbCidade.TabIndex = 12;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(171, 317);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(344, 27);
            this.txbEndereco.TabIndex = 13;
            // 
            // txbNumero
            // 
            this.txbNumero.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumero.Location = new System.Drawing.Point(636, 317);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(99, 27);
            this.txbNumero.TabIndex = 14;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(544, 325);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 19);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Número:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 375);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(138, 19);
            this.lblDataNascimento.TabIndex = 16;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // lblQuartoPreferido
            // 
            this.lblQuartoPreferido.AutoSize = true;
            this.lblQuartoPreferido.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartoPreferido.Location = new System.Drawing.Point(12, 423);
            this.lblQuartoPreferido.Name = "lblQuartoPreferido";
            this.lblQuartoPreferido.Size = new System.Drawing.Size(74, 19);
            this.lblQuartoPreferido.TabIndex = 17;
            this.lblQuartoPreferido.Text = "Telefone:";
            // 
            // dtpDataNascimeto
            // 
            this.dtpDataNascimeto.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimeto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimeto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimeto.Location = new System.Drawing.Point(171, 367);
            this.dtpDataNascimeto.Name = "dtpDataNascimeto";
            this.dtpDataNascimeto.Size = new System.Drawing.Size(135, 27);
            this.dtpDataNascimeto.TabIndex = 18;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(344, 465);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(171, 71);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbCpf
            // 
            this.txbCpf.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(171, 186);
            this.txbCpf.Mask = "000.000.000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(135, 27);
            this.txbCpf.TabIndex = 21;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(171, 415);
            this.txbTelefone.Mask = "(99) 0 0000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(143, 27);
            this.txbTelefone.TabIndex = 22;
            // 
            // txbRg
            // 
            this.txbRg.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRg.Location = new System.Drawing.Point(171, 229);
            this.txbRg.Mask = "00.000.000-0";
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(124, 27);
            this.txbRg.TabIndex = 23;
            // 
            // frm_CadastroHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 548);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtpDataNascimeto);
            this.Controls.Add(this.lblQuartoPreferido);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCadastrarHospede);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrarHospede);
            this.MaximizeBox = false;
            this.Name = "frm_CadastroHospede";
            this.Text = "Cadastrar Hospede";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarHospede;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCadastrarHospede;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblQuartoPreferido;
        private System.Windows.Forms.DateTimePicker dtpDataNascimeto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.MaskedTextBox txbRg;
    }
}