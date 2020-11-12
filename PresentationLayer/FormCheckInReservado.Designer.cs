namespace PresentationLayer
{
    partial class FormCheckInReservado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFundoCheckIn = new System.Windows.Forms.Panel();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelReservas = new System.Windows.Forms.Label();
            this.panelCpfBuscca = new System.Windows.Forms.Panel();
            this.txtCpfBusca = new System.Windows.Forms.TextBox();
            this.linhaCPFClienteBusca = new System.Windows.Forms.Label();
            this.btnBuscarCPF = new System.Windows.Forms.Button();
            this.panelDados = new System.Windows.Forms.Panel();
            this.panelCep = new System.Windows.Forms.Panel();
            this.linhaQuarto = new System.Windows.Forms.Label();
            this.labelQuarto = new System.Windows.Forms.Label();
            this.labelDados = new System.Windows.Forms.Label();
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.linhaData = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.panelReserva = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linhaCPF = new System.Windows.Forms.Label();
            this.panelFundoCheckIn.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelCpfBuscca.SuspendLayout();
            this.panelDados.SuspendLayout();
            this.panelCep.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.panelReserva.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundoCheckIn
            // 
            this.panelFundoCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFundoCheckIn.Controls.Add(this.labelCheckIn);
            this.panelFundoCheckIn.Location = new System.Drawing.Point(337, 26);
            this.panelFundoCheckIn.Name = "panelFundoCheckIn";
            this.panelFundoCheckIn.Size = new System.Drawing.Size(133, 48);
            this.panelFundoCheckIn.TabIndex = 23;
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCheckIn.Font = new System.Drawing.Font("GatsbyFLF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelCheckIn.Location = new System.Drawing.Point(0, 0);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(133, 48);
            this.labelCheckIn.TabIndex = 53;
            this.labelCheckIn.Text = "Check In";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelFundoCheckIn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 100);
            this.panelTop.TabIndex = 79;
            // 
            // labelReservas
            // 
            this.labelReservas.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelReservas.Location = new System.Drawing.Point(36, 0);
            this.labelReservas.Name = "labelReservas";
            this.labelReservas.Size = new System.Drawing.Size(100, 42);
            this.labelReservas.TabIndex = 73;
            this.labelReservas.Text = "Reservas";
            // 
            // panelCpfBuscca
            // 
            this.panelCpfBuscca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCpfBuscca.Controls.Add(this.linhaCPFClienteBusca);
            this.panelCpfBuscca.Controls.Add(this.txtCpfBusca);
            this.panelCpfBuscca.Location = new System.Drawing.Point(42, 45);
            this.panelCpfBuscca.Name = "panelCpfBuscca";
            this.panelCpfBuscca.Size = new System.Drawing.Size(197, 32);
            this.panelCpfBuscca.TabIndex = 80;
            // 
            // txtCpfBusca
            // 
            this.txtCpfBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCpfBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpfBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCpfBusca.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfBusca.ForeColor = System.Drawing.Color.Silver;
            this.txtCpfBusca.Location = new System.Drawing.Point(0, 0);
            this.txtCpfBusca.Name = "txtCpfBusca";
            this.txtCpfBusca.Size = new System.Drawing.Size(197, 30);
            this.txtCpfBusca.TabIndex = 23;
            this.txtCpfBusca.Text = "Por CPF do cliente...";
            // 
            // linhaCPFClienteBusca
            // 
            this.linhaCPFClienteBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCPFClienteBusca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCPFClienteBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCPFClienteBusca.Location = new System.Drawing.Point(0, 31);
            this.linhaCPFClienteBusca.Name = "linhaCPFClienteBusca";
            this.linhaCPFClienteBusca.Size = new System.Drawing.Size(197, 1);
            this.linhaCPFClienteBusca.TabIndex = 24;
            // 
            // btnBuscarCPF
            // 
            this.btnBuscarCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscarCPF.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarCPF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnBuscarCPF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnBuscarCPF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCPF.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnBuscarCPF.Location = new System.Drawing.Point(293, 45);
            this.btnBuscarCPF.Name = "btnBuscarCPF";
            this.btnBuscarCPF.Size = new System.Drawing.Size(86, 32);
            this.btnBuscarCPF.TabIndex = 81;
            this.btnBuscarCPF.Text = "BUSCAR";
            this.btnBuscarCPF.UseVisualStyleBackColor = false;
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.panel1);
            this.panelDados.Controls.Add(this.panelData);
            this.panelDados.Controls.Add(this.btnCadastrar);
            this.panelDados.Controls.Add(this.labelDados);
            this.panelDados.Controls.Add(this.panelCep);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDados.Location = new System.Drawing.Point(435, 0);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(365, 350);
            this.panelDados.TabIndex = 78;
            // 
            // panelCep
            // 
            this.panelCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCep.Controls.Add(this.labelQuarto);
            this.panelCep.Controls.Add(this.linhaQuarto);
            this.panelCep.Location = new System.Drawing.Point(11, 68);
            this.panelCep.Name = "panelCep";
            this.panelCep.Size = new System.Drawing.Size(344, 32);
            this.panelCep.TabIndex = 70;
            // 
            // linhaQuarto
            // 
            this.linhaQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaQuarto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaQuarto.Location = new System.Drawing.Point(0, 31);
            this.linhaQuarto.Name = "linhaQuarto";
            this.linhaQuarto.Size = new System.Drawing.Size(344, 1);
            this.linhaQuarto.TabIndex = 24;
            // 
            // labelQuarto
            // 
            this.labelQuarto.AutoSize = true;
            this.labelQuarto.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuarto.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuarto.ForeColor = System.Drawing.Color.Silver;
            this.labelQuarto.Location = new System.Drawing.Point(0, 0);
            this.labelQuarto.Name = "labelQuarto";
            this.labelQuarto.Size = new System.Drawing.Size(72, 29);
            this.labelQuarto.TabIndex = 64;
            this.labelQuarto.Text = "Quarto";
            // 
            // labelDados
            // 
            this.labelDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDados.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelDados.Location = new System.Drawing.Point(3, 3);
            this.labelDados.Name = "labelDados";
            this.labelDados.Size = new System.Drawing.Size(97, 42);
            this.labelDados.TabIndex = 72;
            this.labelDados.Text = "Dados";
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.AutoSize = true;
            this.labelDataSaida.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDataSaida.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataSaida.ForeColor = System.Drawing.Color.Silver;
            this.labelDataSaida.Location = new System.Drawing.Point(0, 0);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(126, 29);
            this.labelDataSaida.TabIndex = 73;
            this.labelDataSaida.Text = "Data de Saida";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCadastrar.Location = new System.Drawing.Point(126, 279);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 32);
            this.btnCadastrar.TabIndex = 82;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.linhaData);
            this.panelData.Controls.Add(this.labelDataSaida);
            this.panelData.Location = new System.Drawing.Point(11, 200);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(344, 32);
            this.panelData.TabIndex = 71;
            // 
            // linhaData
            // 
            this.linhaData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaData.Location = new System.Drawing.Point(0, 31);
            this.linhaData.Name = "linhaData";
            this.linhaData.Size = new System.Drawing.Size(344, 1);
            this.linhaData.TabIndex = 24;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCpf.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.ForeColor = System.Drawing.Color.Silver;
            this.labelCpf.Location = new System.Drawing.Point(0, 0);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(126, 29);
            this.labelCpf.TabIndex = 74;
            this.labelCpf.Text = "CPF do Cliente";
            this.labelCpf.Visible = false;
            // 
            // dgvReservas
            // 
            this.dgvReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dgvReservas.Location = new System.Drawing.Point(0, 84);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(435, 266);
            this.dgvReservas.TabIndex = 79;
            // 
            // panelReserva
            // 
            this.panelReserva.Controls.Add(this.btnBuscarCPF);
            this.panelReserva.Controls.Add(this.dgvReservas);
            this.panelReserva.Controls.Add(this.panelDados);
            this.panelReserva.Controls.Add(this.panelCpfBuscca);
            this.panelReserva.Controls.Add(this.labelReservas);
            this.panelReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReserva.Location = new System.Drawing.Point(0, 100);
            this.panelReserva.Name = "panelReserva";
            this.panelReserva.Size = new System.Drawing.Size(800, 350);
            this.panelReserva.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linhaCPF);
            this.panel1.Controls.Add(this.labelCpf);
            this.panel1.Location = new System.Drawing.Point(11, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 32);
            this.panel1.TabIndex = 83;
            // 
            // linhaCPF
            // 
            this.linhaCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCPF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCPF.Location = new System.Drawing.Point(0, 31);
            this.linhaCPF.Name = "linhaCPF";
            this.linhaCPF.Size = new System.Drawing.Size(344, 1);
            this.linhaCPF.TabIndex = 24;
            // 
            // FormCheckInReservado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReserva);
            this.Controls.Add(this.panelTop);
            this.Name = "FormCheckInReservado";
            this.Text = "FormCheckInReservado";
            this.panelFundoCheckIn.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelCpfBuscca.ResumeLayout(false);
            this.panelCpfBuscca.PerformLayout();
            this.panelDados.ResumeLayout(false);
            this.panelCep.ResumeLayout(false);
            this.panelCep.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.panelReserva.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundoCheckIn;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelReservas;
        private System.Windows.Forms.Panel panelCpfBuscca;
        private System.Windows.Forms.Label linhaCPFClienteBusca;
        private System.Windows.Forms.TextBox txtCpfBusca;
        private System.Windows.Forms.Button btnBuscarCPF;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label linhaCPF;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label linhaData;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label labelDados;
        private System.Windows.Forms.Panel panelCep;
        private System.Windows.Forms.Label labelQuarto;
        private System.Windows.Forms.Label linhaQuarto;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel panelReserva;
    }
}