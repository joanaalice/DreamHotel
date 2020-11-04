namespace PresentationLayer
{
    partial class FormCadastroReserva
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
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelDadosPessoais = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.labelDadosPessoais = new System.Windows.Forms.Label();
            this.panelEndereco = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelCep = new System.Windows.Forms.Panel();
            this.linhaCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelCadastroCliente = new System.Windows.Forms.Panel();
            this.labelCadastroDeCliente = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.panelFundo.SuspendLayout();
            this.panelDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.panelEndereco.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCep.SuspendLayout();
            this.panelCadastrar.SuspendLayout();
            this.panelCadastroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFundo.Controls.Add(this.panelDadosPessoais);
            this.panelFundo.Controls.Add(this.panelEndereco);
            this.panelFundo.Location = new System.Drawing.Point(0, 80);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(800, 286);
            this.panelFundo.TabIndex = 70;
            // 
            // panelDadosPessoais
            // 
            this.panelDadosPessoais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelDadosPessoais.Controls.Add(this.dgvReservas);
            this.panelDadosPessoais.Controls.Add(this.labelDadosPessoais);
            this.panelDadosPessoais.Location = new System.Drawing.Point(2, -1);
            this.panelDadosPessoais.Name = "panelDadosPessoais";
            this.panelDadosPessoais.Size = new System.Drawing.Size(393, 293);
            this.panelDadosPessoais.TabIndex = 65;
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
            this.dgvReservas.Location = new System.Drawing.Point(0, 78);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(393, 215);
            this.dgvReservas.TabIndex = 78;
            // 
            // labelDadosPessoais
            // 
            this.labelDadosPessoais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDadosPessoais.Font = new System.Drawing.Font("GatsbyFLF", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosPessoais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelDadosPessoais.Location = new System.Drawing.Point(33, 23);
            this.labelDadosPessoais.Name = "labelDadosPessoais";
            this.labelDadosPessoais.Size = new System.Drawing.Size(246, 42);
            this.labelDadosPessoais.TabIndex = 50;
            this.labelDadosPessoais.Text = "Quartos disponíveis";
            // 
            // panelEndereco
            // 
            this.panelEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelEndereco.Controls.Add(this.labelNome);
            this.panelEndereco.Controls.Add(this.dateTimePicker1);
            this.panelEndereco.Controls.Add(this.panel1);
            this.panelEndereco.Controls.Add(this.panelCep);
            this.panelEndereco.Controls.Add(this.labelEndereco);
            this.panelEndereco.Location = new System.Drawing.Point(394, 0);
            this.panelEndereco.Name = "panelEndereco";
            this.panelEndereco.Size = new System.Drawing.Size(404, 293);
            this.panelEndereco.TabIndex = 66;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Silver;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(345, 20);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(34, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 32);
            this.panel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 1);
            this.label1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("GatsbyFLF", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 29);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "CPF do Cliente";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panelCep
            // 
            this.panelCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCep.Controls.Add(this.linhaCep);
            this.panelCep.Controls.Add(this.txtCep);
            this.panelCep.Location = new System.Drawing.Point(34, 76);
            this.panelCep.Name = "panelCep";
            this.panelCep.Size = new System.Drawing.Size(344, 32);
            this.panelCep.TabIndex = 57;
            // 
            // linhaCep
            // 
            this.linhaCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCep.Location = new System.Drawing.Point(0, 31);
            this.linhaCep.Name = "linhaCep";
            this.linhaCep.Size = new System.Drawing.Size(344, 1);
            this.linhaCep.TabIndex = 24;
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCep.Font = new System.Drawing.Font("GatsbyFLF", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.ForeColor = System.Drawing.Color.Silver;
            this.txtCep.Location = new System.Drawing.Point(0, 0);
            this.txtCep.Name = "txtCep";
            this.txtCep.ReadOnly = true;
            this.txtCep.Size = new System.Drawing.Size(344, 29);
            this.txtCep.TabIndex = 30;
            this.txtCep.Text = "Quarto";
            // 
            // labelEndereco
            // 
            this.labelEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEndereco.Font = new System.Drawing.Font("GatsbyFLF", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelEndereco.Location = new System.Drawing.Point(26, 22);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(117, 42);
            this.labelEndereco.TabIndex = 51;
            this.labelEndereco.Text = "Dados";
            // 
            // panelCadastrar
            // 
            this.panelCadastrar.Controls.Add(this.btnCadastrar);
            this.panelCadastrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCadastrar.Location = new System.Drawing.Point(0, 366);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(800, 84);
            this.panelCadastrar.TabIndex = 69;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCadastrar.Location = new System.Drawing.Point(186, 10);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(423, 45);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "RESERVAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelCadastroCliente
            // 
            this.panelCadastroCliente.Controls.Add(this.labelCadastroDeCliente);
            this.panelCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastroCliente.Location = new System.Drawing.Point(0, 0);
            this.panelCadastroCliente.Name = "panelCadastroCliente";
            this.panelCadastroCliente.Size = new System.Drawing.Size(800, 96);
            this.panelCadastroCliente.TabIndex = 68;
            // 
            // labelCadastroDeCliente
            // 
            this.labelCadastroDeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCadastroDeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.labelCadastroDeCliente.FlatAppearance.BorderSize = 0;
            this.labelCadastroDeCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCadastroDeCliente.Font = new System.Drawing.Font("GatsbyFLF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroDeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelCadastroDeCliente.Location = new System.Drawing.Point(219, 24);
            this.labelCadastroDeCliente.Name = "labelCadastroDeCliente";
            this.labelCadastroDeCliente.Size = new System.Drawing.Size(348, 69);
            this.labelCadastroDeCliente.TabIndex = 23;
            this.labelCadastroDeCliente.Text = "RESERVAR";
            this.labelCadastroDeCliente.UseVisualStyleBackColor = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNome.Location = new System.Drawing.Point(37, 178);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 63;
            this.labelNome.Text = "label2";
            // 
            // FormCadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCadastroCliente);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelCadastrar);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormCadastroReserva";
            this.Text = "FormCadastrarReserva";
            this.panelFundo.ResumeLayout(false);
            this.panelDadosPessoais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.panelEndereco.ResumeLayout(false);
            this.panelEndereco.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCep.ResumeLayout(false);
            this.panelCep.PerformLayout();
            this.panelCadastrar.ResumeLayout(false);
            this.panelCadastroCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelDadosPessoais;
        private System.Windows.Forms.Label labelDadosPessoais;
        private System.Windows.Forms.Panel panelEndereco;
        private System.Windows.Forms.Panel panelCep;
        private System.Windows.Forms.Label linhaCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Panel panelCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelCadastroCliente;
        private System.Windows.Forms.Button labelCadastroDeCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelNome;
    }
}