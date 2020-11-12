namespace PresentationLayer
{
    partial class FormReservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCalendario = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.panelFiltrar = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelQuarto = new System.Windows.Forms.Panel();
            this.linhaQuarto = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.panelCpf = new System.Windows.Forms.Panel();
            this.linhaCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.panelFundoCadstroCliente = new System.Windows.Forms.Panel();
            this.labelReservas = new System.Windows.Forms.Label();
            this.panelCalendario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.panelFiltrar.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panelQuarto.SuspendLayout();
            this.panelCpf.SuspendLayout();
            this.panelFundoCadstroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCalendario
            // 
            this.panelCalendario.Controls.Add(this.monthCalendar);
            this.panelCalendario.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCalendario.Location = new System.Drawing.Point(0, 0);
            this.panelCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.panelCalendario.MinimumSize = new System.Drawing.Size(270, 587);
            this.panelCalendario.Name = "panelCalendario";
            this.panelCalendario.Size = new System.Drawing.Size(270, 587);
            this.panelCalendario.TabIndex = 1;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.Black;
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar.ForeColor = System.Drawing.Color.Silver;
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.MaximumSize = new System.Drawing.Size(269, 777);
            this.monthCalendar.MinimumSize = new System.Drawing.Size(269, 587);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.Black;
            this.monthCalendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.monthCalendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // dgvReservas
            // 
            this.dgvReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dgvReservas.Location = new System.Drawing.Point(303, 174);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(764, 329);
            this.dgvReservas.TabIndex = 77;
            // 
            // panelFiltrar
            // 
            this.panelFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFiltrar.Controls.Add(this.btnDeletar);
            this.panelFiltrar.Controls.Add(this.btnEditar);
            this.panelFiltrar.Location = new System.Drawing.Point(303, 503);
            this.panelFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.panelFiltrar.Name = "panelFiltrar";
            this.panelFiltrar.Size = new System.Drawing.Size(764, 84);
            this.panelFiltrar.TabIndex = 78;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDeletar.Location = new System.Drawing.Point(391, 18);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(121, 39);
            this.btnDeletar.TabIndex = 81;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnEditar.Location = new System.Drawing.Point(261, 18);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 39);
            this.btnEditar.TabIndex = 80;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.panelQuarto);
            this.panelBuscar.Controls.Add(this.panelCpf);
            this.panelBuscar.Controls.Add(this.panelFundoCadstroCliente);
            this.panelBuscar.Location = new System.Drawing.Point(303, 0);
            this.panelBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(764, 174);
            this.panelBuscar.TabIndex = 79;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnBuscar.Location = new System.Drawing.Point(321, 110);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 39);
            this.btnBuscar.TabIndex = 69;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelQuarto
            // 
            this.panelQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelQuarto.Controls.Add(this.linhaQuarto);
            this.panelQuarto.Controls.Add(this.txtQuarto);
            this.panelQuarto.Location = new System.Drawing.Point(472, 110);
            this.panelQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.panelQuarto.Name = "panelQuarto";
            this.panelQuarto.Size = new System.Drawing.Size(263, 39);
            this.panelQuarto.TabIndex = 68;
            // 
            // linhaQuarto
            // 
            this.linhaQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaQuarto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaQuarto.Location = new System.Drawing.Point(0, 38);
            this.linhaQuarto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linhaQuarto.Name = "linhaQuarto";
            this.linhaQuarto.Size = new System.Drawing.Size(263, 1);
            this.linhaQuarto.TabIndex = 24;
            // 
            // txtQuarto
            // 
            this.txtQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuarto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuarto.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarto.ForeColor = System.Drawing.Color.Silver;
            this.txtQuarto.Location = new System.Drawing.Point(0, 0);
            this.txtQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(263, 37);
            this.txtQuarto.TabIndex = 23;
            this.txtQuarto.Text = "Por número do quarto...";
            this.txtQuarto.Enter += new System.EventHandler(this.txtQuarto_Enter);
            this.txtQuarto.Leave += new System.EventHandler(this.txtQuarto_Leave);
            // 
            // panelCpf
            // 
            this.panelCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCpf.Controls.Add(this.linhaCpf);
            this.panelCpf.Controls.Add(this.txtCpf);
            this.panelCpf.Location = new System.Drawing.Point(33, 110);
            this.panelCpf.Margin = new System.Windows.Forms.Padding(4);
            this.panelCpf.Name = "panelCpf";
            this.panelCpf.Size = new System.Drawing.Size(263, 39);
            this.panelCpf.TabIndex = 67;
            // 
            // linhaCpf
            // 
            this.linhaCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCpf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCpf.Location = new System.Drawing.Point(0, 38);
            this.linhaCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linhaCpf.Name = "linhaCpf";
            this.linhaCpf.Size = new System.Drawing.Size(263, 1);
            this.linhaCpf.TabIndex = 24;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCpf.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Silver;
            this.txtCpf.Location = new System.Drawing.Point(0, 0);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(263, 37);
            this.txtCpf.TabIndex = 23;
            this.txtCpf.Text = "Por CPF do cliente...";
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // panelFundoCadstroCliente
            // 
            this.panelFundoCadstroCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFundoCadstroCliente.Controls.Add(this.labelReservas);
            this.panelFundoCadstroCliente.Location = new System.Drawing.Point(288, 15);
            this.panelFundoCadstroCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panelFundoCadstroCliente.Name = "panelFundoCadstroCliente";
            this.panelFundoCadstroCliente.Size = new System.Drawing.Size(179, 59);
            this.panelFundoCadstroCliente.TabIndex = 23;
            // 
            // labelReservas
            // 
            this.labelReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReservas.Font = new System.Drawing.Font("GatsbyFLF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelReservas.Location = new System.Drawing.Point(0, 0);
            this.labelReservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReservas.Name = "labelReservas";
            this.labelReservas.Size = new System.Drawing.Size(179, 59);
            this.labelReservas.TabIndex = 53;
            this.labelReservas.Text = "Reservas";
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1067, 587);
            this.Controls.Add(this.panelCalendario);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panelFiltrar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1085, 634);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            this.panelCalendario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.panelFiltrar.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelQuarto.ResumeLayout(false);
            this.panelQuarto.PerformLayout();
            this.panelCpf.ResumeLayout(false);
            this.panelCpf.PerformLayout();
            this.panelFundoCadstroCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCalendario;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel panelFiltrar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Panel panelFundoCadstroCliente;
        private System.Windows.Forms.Panel panelQuarto;
        private System.Windows.Forms.Label linhaQuarto;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Panel panelCpf;
        private System.Windows.Forms.Label linhaCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelReservas;
    }
}