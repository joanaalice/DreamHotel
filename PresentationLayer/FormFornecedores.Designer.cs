namespace PresentationLayer
{
    partial class FormFornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelFundoFornecedores = new System.Windows.Forms.Panel();
            this.labelFornecedores = new System.Windows.Forms.Label();
            this.panelCnpj = new System.Windows.Forms.Panel();
            this.linhaCnpj = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnTelefone2 = new System.Windows.Forms.Button();
            this.btnCnpj = new System.Windows.Forms.Button();
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.btnTelefone = new System.Windows.Forms.Button();
            this.btnRazaoSocial = new System.Windows.Forms.Button();
            this.btnNome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelFundoFornecedores.SuspendLayout();
            this.panelCnpj.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            this.panelDireita.SuspendLayout();
            this.panelEsquerda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedores.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFornecedores.EnableHeadersVisualStyles = false;
            this.dgvFornecedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dgvFornecedores.Location = new System.Drawing.Point(0, 154);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(800, 235);
            this.dgvFornecedores.TabIndex = 78;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelFundoFornecedores);
            this.panelTop.Controls.Add(this.panelCnpj);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 154);
            this.panelTop.TabIndex = 77;
            // 
            // panelFundoFornecedores
            // 
            this.panelFundoFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFundoFornecedores.Controls.Add(this.labelFornecedores);
            this.panelFundoFornecedores.Location = new System.Drawing.Point(297, 22);
            this.panelFundoFornecedores.Name = "panelFundoFornecedores";
            this.panelFundoFornecedores.Size = new System.Drawing.Size(212, 48);
            this.panelFundoFornecedores.TabIndex = 22;
            // 
            // labelFornecedores
            // 
            this.labelFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFornecedores.Font = new System.Drawing.Font("GatsbyFLF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelFornecedores.Location = new System.Drawing.Point(0, 0);
            this.labelFornecedores.Name = "labelFornecedores";
            this.labelFornecedores.Size = new System.Drawing.Size(212, 48);
            this.labelFornecedores.TabIndex = 53;
            this.labelFornecedores.Text = "Fornecedores";
            // 
            // panelCnpj
            // 
            this.panelCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCnpj.Controls.Add(this.linhaCnpj);
            this.panelCnpj.Controls.Add(this.txtCnpj);
            this.panelCnpj.Location = new System.Drawing.Point(195, 102);
            this.panelCnpj.Name = "panelCnpj";
            this.panelCnpj.Size = new System.Drawing.Size(284, 32);
            this.panelCnpj.TabIndex = 66;
            // 
            // linhaCnpj
            // 
            this.linhaCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCnpj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCnpj.Location = new System.Drawing.Point(0, 31);
            this.linhaCnpj.Name = "linhaCnpj";
            this.linhaCnpj.Size = new System.Drawing.Size(284, 1);
            this.linhaCnpj.TabIndex = 24;
            // 
            // txtCnpj
            // 
            this.txtCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnpj.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCnpj.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.ForeColor = System.Drawing.Color.Silver;
            this.txtCnpj.Location = new System.Drawing.Point(0, 0);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(284, 35);
            this.txtCnpj.TabIndex = 23;
            this.txtCnpj.Text = "Por CNPJ...";
            this.txtCnpj.Enter += new System.EventHandler(this.txtCnpj_Enter);
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
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
            this.btnBuscar.Location = new System.Drawing.Point(513, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 32);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDeletar);
            this.panelBottom.Controls.Add(this.btnFiltrar);
            this.panelBottom.Controls.Add(this.btnEditar);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 389);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 61);
            this.panelBottom.TabIndex = 76;
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
            this.btnDeletar.Location = new System.Drawing.Point(454, 9);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(91, 32);
            this.btnDeletar.TabIndex = 69;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnFiltrar.Location = new System.Drawing.Point(357, 9);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(91, 32);
            this.btnFiltrar.TabIndex = 70;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(260, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 32);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelFiltro
            // 
            this.panelFiltro.BackColor = System.Drawing.Color.Black;
            this.panelFiltro.Controls.Add(this.panelDireita);
            this.panelFiltro.Controls.Add(this.panelEsquerda);
            this.panelFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.panelFiltro.Location = new System.Drawing.Point(277, 299);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(255, 95);
            this.panelFiltro.TabIndex = 75;
            this.panelFiltro.Visible = false;
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.Color.Black;
            this.panelDireita.Controls.Add(this.btnEmail);
            this.panelDireita.Controls.Add(this.btnTelefone2);
            this.panelDireita.Controls.Add(this.btnCnpj);
            this.panelDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDireita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.panelDireita.Location = new System.Drawing.Point(128, 0);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(127, 95);
            this.panelDireita.TabIndex = 76;
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Black;
            this.btnEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnEmail.Location = new System.Drawing.Point(0, 32);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(127, 33);
            this.btnEmail.TabIndex = 74;
            this.btnEmail.Text = "EMAIL";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnTelefone2
            // 
            this.btnTelefone2.BackColor = System.Drawing.Color.Black;
            this.btnTelefone2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTelefone2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTelefone2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTelefone2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTelefone2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelefone2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelefone2.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTelefone2.Location = new System.Drawing.Point(0, 62);
            this.btnTelefone2.Name = "btnTelefone2";
            this.btnTelefone2.Size = new System.Drawing.Size(127, 33);
            this.btnTelefone2.TabIndex = 78;
            this.btnTelefone2.Text = "TELEFONE*";
            this.btnTelefone2.UseVisualStyleBackColor = false;
            this.btnTelefone2.Click += new System.EventHandler(this.btnTelefone2_Click);
            // 
            // btnCnpj
            // 
            this.btnCnpj.BackColor = System.Drawing.Color.Black;
            this.btnCnpj.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCnpj.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCnpj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCnpj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCnpj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCnpj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCnpj.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCnpj.Location = new System.Drawing.Point(0, 0);
            this.btnCnpj.Name = "btnCnpj";
            this.btnCnpj.Size = new System.Drawing.Size(127, 32);
            this.btnCnpj.TabIndex = 72;
            this.btnCnpj.Text = "CNPJ";
            this.btnCnpj.UseVisualStyleBackColor = false;
            this.btnCnpj.Click += new System.EventHandler(this.btnCnpj_Click);
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.Color.Black;
            this.panelEsquerda.Controls.Add(this.btnTelefone);
            this.panelEsquerda.Controls.Add(this.btnRazaoSocial);
            this.panelEsquerda.Controls.Add(this.btnNome);
            this.panelEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.panelEsquerda.Location = new System.Drawing.Point(0, 0);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(128, 95);
            this.panelEsquerda.TabIndex = 75;
            // 
            // btnTelefone
            // 
            this.btnTelefone.BackColor = System.Drawing.Color.Black;
            this.btnTelefone.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTelefone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTelefone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTelefone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTelefone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelefone.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTelefone.Location = new System.Drawing.Point(0, 63);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(128, 32);
            this.btnTelefone.TabIndex = 73;
            this.btnTelefone.Text = "TELEFONE";
            this.btnTelefone.UseVisualStyleBackColor = false;
            this.btnTelefone.Click += new System.EventHandler(this.btnTelefone_Click);
            // 
            // btnRazaoSocial
            // 
            this.btnRazaoSocial.BackColor = System.Drawing.Color.Black;
            this.btnRazaoSocial.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRazaoSocial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRazaoSocial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnRazaoSocial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnRazaoSocial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRazaoSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRazaoSocial.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnRazaoSocial.Location = new System.Drawing.Point(0, 32);
            this.btnRazaoSocial.Name = "btnRazaoSocial";
            this.btnRazaoSocial.Size = new System.Drawing.Size(128, 32);
            this.btnRazaoSocial.TabIndex = 77;
            this.btnRazaoSocial.Text = "RAZAO S.";
            this.btnRazaoSocial.UseVisualStyleBackColor = false;
            this.btnRazaoSocial.Click += new System.EventHandler(this.btnRazaoSocial_Click);
            // 
            // btnNome
            // 
            this.btnNome.BackColor = System.Drawing.Color.Black;
            this.btnNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnNome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnNome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNome.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnNome.Location = new System.Drawing.Point(0, 0);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(128, 32);
            this.btnNome.TabIndex = 76;
            this.btnNome.Text = "NOME C.";
            this.btnNome.UseVisualStyleBackColor = false;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelFundoFornecedores.ResumeLayout(false);
            this.panelCnpj.ResumeLayout(false);
            this.panelCnpj.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelFiltro.ResumeLayout(false);
            this.panelDireita.ResumeLayout(false);
            this.panelEsquerda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFundoFornecedores;
        private System.Windows.Forms.Label labelFornecedores;
        private System.Windows.Forms.Panel panelCnpj;
        private System.Windows.Forms.Label linhaCnpj;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnTelefone2;
        private System.Windows.Forms.Button btnCnpj;
        private System.Windows.Forms.Panel panelEsquerda;
        private System.Windows.Forms.Button btnTelefone;
        private System.Windows.Forms.Button btnRazaoSocial;
        private System.Windows.Forms.Button btnNome;
    }
}