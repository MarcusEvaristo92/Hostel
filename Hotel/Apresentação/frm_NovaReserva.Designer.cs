
namespace Hotel
{
    partial class frm_NovaReserva
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbId = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.dgvHospede = new System.Windows.Forms.DataGridView();
            this.hostelDataSetHospedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dgvQuartosDisponiveis = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbQuarto = new System.Windows.Forms.Label();
            this.txbQuarto = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.hostelDataSetHospede = new Hotel.HostelDataSetHospede();
            this.hostelDataSetHospedeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbHospedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbHospedeTableAdapter = new Hotel.HostelDataSetHospedeTableAdapters.tbHospedeTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetHospedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetHospede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetHospedeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHospedeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(49, 27);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(31, 19);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(49, 69);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(40, 19);
            this.lbCpf.TabIndex = 1;
            this.lbCpf.Text = "Cpf:";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.Location = new System.Drawing.Point(47, 139);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(81, 19);
            this.lbCheckIn.TabIndex = 2;
            this.lbCheckIn.Text = "Check-In:";
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.AutoSize = true;
            this.lbCheckOut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOut.Location = new System.Drawing.Point(47, 186);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(92, 19);
            this.lbCheckOut.TabIndex = 3;
            this.lbCheckOut.Text = "Check-Out:";
            // 
            // dgvHospede
            // 
            this.dgvHospede.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHospede.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHospede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgvHospede.DataSource = this.tbHospedeBindingSource;
            this.dgvHospede.Location = new System.Drawing.Point(393, 19);
            this.dgvHospede.Name = "dgvHospede";
            this.dgvHospede.RowHeadersVisible = false;
            this.dgvHospede.RowHeadersWidth = 51;
            this.dgvHospede.RowTemplate.Height = 24;
            this.dgvHospede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospede.Size = new System.Drawing.Size(329, 67);
            this.dgvHospede.TabIndex = 4;
            this.dgvHospede.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(97, 19);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(271, 27);
            this.txbId.TabIndex = 5;
            // 
            // txbCpf
            // 
            this.txbCpf.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(97, 66);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(271, 27);
            this.txbCpf.TabIndex = 6;
            this.txbCpf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(146, 133);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(132, 27);
            this.dtpCheckIn.TabIndex = 7;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(146, 178);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(132, 27);
            this.dtpCheckOut.TabIndex = 8;
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(80, 283);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(163, 63);
            this.btnReservar.TabIndex = 9;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // dgvQuartosDisponiveis
            // 
            this.dgvQuartosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartosDisponiveis.Location = new System.Drawing.Point(312, 133);
            this.dgvQuartosDisponiveis.Name = "dgvQuartosDisponiveis";
            this.dgvQuartosDisponiveis.RowHeadersWidth = 51;
            this.dgvQuartosDisponiveis.RowTemplate.Height = 24;
            this.dgvQuartosDisponiveis.Size = new System.Drawing.Size(423, 311);
            this.dgvQuartosDisponiveis.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quartos disponíveis";
            // 
            // lbQuarto
            // 
            this.lbQuarto.AutoSize = true;
            this.lbQuarto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuarto.Location = new System.Drawing.Point(48, 233);
            this.lbQuarto.Name = "lbQuarto";
            this.lbQuarto.Size = new System.Drawing.Size(63, 19);
            this.lbQuarto.TabIndex = 12;
            this.lbQuarto.Text = "Quarto:";
            // 
            // txbQuarto
            // 
            this.txbQuarto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuarto.Location = new System.Drawing.Point(146, 225);
            this.txbQuarto.Name = "txbQuarto";
            this.txbQuarto.Size = new System.Drawing.Size(98, 27);
            this.txbQuarto.TabIndex = 13;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(80, 381);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(163, 63);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // hostelDataSetHospede
            // 
            this.hostelDataSetHospede.DataSetName = "HostelDataSetHospede";
            this.hostelDataSetHospede.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hostelDataSetHospedeBindingSource1
            // 
            this.hostelDataSetHospedeBindingSource1.DataSource = this.hostelDataSetHospede;
            this.hostelDataSetHospedeBindingSource1.Position = 0;
            // 
            // tbHospedeBindingSource
            // 
            this.tbHospedeBindingSource.DataMember = "tbHospede";
            this.tbHospedeBindingSource.DataSource = this.hostelDataSetHospedeBindingSource1;
            // 
            // tbHospedeTableAdapter
            // 
            this.tbHospedeTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.Width = 125;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.Visible = false;
            this.rgDataGridViewTextBoxColumn.Width = 125;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.Visible = false;
            this.cidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            this.enderecoDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.Visible = false;
            this.numeroDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "dataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.Visible = false;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Visible = false;
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // frm_NovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txbQuarto);
            this.Controls.Add(this.lbQuarto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvQuartosDisponiveis);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.dgvHospede);
            this.Controls.Add(this.lbCheckOut);
            this.Controls.Add(this.lbCheckIn);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbId);
            this.Name = "frm_NovaReserva";
            this.Text = "Nova Reserva";
            this.Load += new System.EventHandler(this.frm_NovaReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetHospedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetHospede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetHospedeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHospedeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.Label lbCheckOut;
        private System.Windows.Forms.DataGridView dgvHospede;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgvQuartosDisponiveis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbQuarto;
        private System.Windows.Forms.TextBox txbQuarto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.BindingSource hostelDataSetHospedeBindingSource;
        private HostelDataSetHospede hostelDataSetHospede;
        private System.Windows.Forms.BindingSource hostelDataSetHospedeBindingSource1;
        private System.Windows.Forms.BindingSource tbHospedeBindingSource;
        private HostelDataSetHospedeTableAdapters.tbHospedeTableAdapter tbHospedeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}