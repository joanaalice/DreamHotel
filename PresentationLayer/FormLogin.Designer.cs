namespace PresentationLayer
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.linkCadastrar = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.linhaUsuario = new System.Windows.Forms.Label();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.linhaSenha = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.panelUsuario.SuspendLayout();
            this.panelSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 330);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(63, 72);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(121, 182);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(736, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(757, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(15, 15);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 14;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // linkCadastrar
            // 
            this.linkCadastrar.ActiveLinkColor = System.Drawing.Color.White;
            this.linkCadastrar.AutoSize = true;
            this.linkCadastrar.Font = new System.Drawing.Font("GatsbyFLF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCadastrar.ForeColor = System.Drawing.Color.Black;
            this.linkCadastrar.LinkColor = System.Drawing.Color.White;
            this.linkCadastrar.Location = new System.Drawing.Point(480, 292);
            this.linkCadastrar.Name = "linkCadastrar";
            this.linkCadastrar.Size = new System.Drawing.Size(65, 20);
            this.linkCadastrar.TabIndex = 9;
            this.linkCadastrar.TabStop = true;
            this.linkCadastrar.Text = "Cadastrar?";
            this.linkCadastrar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrar_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Silver;
            this.btnLogin.Location = new System.Drawing.Point(306, 242);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(408, 40);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("GatsbyFLF", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(477, 28);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(89, 40);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsuario.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(0, 0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(406, 30);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.Text = "Usuário ou email";
            this.txtUsuario.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSenha.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(0, 0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(406, 30);
            this.txtSenha.TabIndex = 17;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // panelUsuario
            // 
            this.panelUsuario.AutoSize = true;
            this.panelUsuario.Controls.Add(this.linhaUsuario);
            this.panelUsuario.Controls.Add(this.txtUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(306, 100);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(406, 31);
            this.panelUsuario.TabIndex = 53;
            // 
            // linhaUsuario
            // 
            this.linhaUsuario.BackColor = System.Drawing.Color.Black;
            this.linhaUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaUsuario.Location = new System.Drawing.Point(0, 30);
            this.linhaUsuario.Name = "linhaUsuario";
            this.linhaUsuario.Size = new System.Drawing.Size(406, 1);
            this.linhaUsuario.TabIndex = 24;
            // 
            // panelSenha
            // 
            this.panelSenha.AutoSize = true;
            this.panelSenha.Controls.Add(this.linhaSenha);
            this.panelSenha.Controls.Add(this.txtSenha);
            this.panelSenha.Location = new System.Drawing.Point(306, 153);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(406, 31);
            this.panelSenha.TabIndex = 54;
            // 
            // linhaSenha
            // 
            this.linhaSenha.BackColor = System.Drawing.Color.Black;
            this.linhaSenha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaSenha.Location = new System.Drawing.Point(0, 30);
            this.linhaSenha.Name = "linhaSenha";
            this.linhaSenha.Size = new System.Drawing.Size(406, 1);
            this.linhaSenha.TabIndex = 24;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(188)))), ((int)(((byte)(83)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.panelSenha);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.linkCadastrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "v";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FormLogin_MouseEnter);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelSenha.ResumeLayout(false);
            this.panelSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.LinkLabel linkCadastrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Label linhaUsuario;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.Label linhaSenha;
    }
}