namespace ZerarNuvem
{
    partial class Form1
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
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.MostrarAmbiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MostraRazaoSocial = new System.Windows.Forms.ComboBox();
            this.CpfCnpjBanco = new System.Windows.Forms.TextBox();
            this.MostraID = new System.Windows.Forms.ComboBox();
            this.MostraCpfCNPJ = new System.Windows.Forms.ComboBox();
            this.SenhaLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FecharLogin = new System.Windows.Forms.Button();
            this.FazerLogin = new System.Windows.Forms.Button();
            this.DesativaAmbiente = new System.Windows.Forms.Button();
            this.SenhaDelete = new System.Windows.Forms.TextBox();
            this.EntrarDelete = new System.Windows.Forms.Button();
            this.SairDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PainelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelMenu
            // 
            this.PainelMenu.Controls.Add(this.label6);
            this.PainelMenu.Controls.Add(this.SairDelete);
            this.PainelMenu.Controls.Add(this.EntrarDelete);
            this.PainelMenu.Controls.Add(this.SenhaDelete);
            this.PainelMenu.Controls.Add(this.DesativaAmbiente);
            this.PainelMenu.Controls.Add(this.label4);
            this.PainelMenu.Controls.Add(this.MostrarAmbiente);
            this.PainelMenu.Controls.Add(this.label2);
            this.PainelMenu.Controls.Add(this.label3);
            this.PainelMenu.Controls.Add(this.label1);
            this.PainelMenu.Controls.Add(this.MostraRazaoSocial);
            this.PainelMenu.Controls.Add(this.CpfCnpjBanco);
            this.PainelMenu.Controls.Add(this.MostraID);
            this.PainelMenu.Controls.Add(this.MostraCpfCNPJ);
            this.PainelMenu.Location = new System.Drawing.Point(12, 99);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(534, 243);
            this.PainelMenu.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID CLINICA";
            // 
            // MostrarAmbiente
            // 
            this.MostrarAmbiente.Location = new System.Drawing.Point(7, 52);
            this.MostrarAmbiente.Name = "MostrarAmbiente";
            this.MostrarAmbiente.Size = new System.Drawing.Size(167, 23);
            this.MostrarAmbiente.TabIndex = 2;
            this.MostrarAmbiente.Text = "BUSCAR";
            this.MostrarAmbiente.UseVisualStyleBackColor = true;
            this.MostrarAmbiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AMBIENTE ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF/CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF/CNPJ DO AMBIENTE";
            // 
            // MostraRazaoSocial
            // 
            this.MostraRazaoSocial.Location = new System.Drawing.Point(10, 99);
            this.MostraRazaoSocial.Name = "MostraRazaoSocial";
            this.MostraRazaoSocial.Size = new System.Drawing.Size(266, 21);
            this.MostraRazaoSocial.TabIndex = 5;
            // 
            // CpfCnpjBanco
            // 
            this.CpfCnpjBanco.Location = new System.Drawing.Point(7, 26);
            this.CpfCnpjBanco.Name = "CpfCnpjBanco";
            this.CpfCnpjBanco.Size = new System.Drawing.Size(167, 20);
            this.CpfCnpjBanco.TabIndex = 0;
            // 
            // MostraID
            // 
            this.MostraID.FormattingEnabled = true;
            this.MostraID.Location = new System.Drawing.Point(10, 179);
            this.MostraID.Name = "MostraID";
            this.MostraID.Size = new System.Drawing.Size(164, 21);
            this.MostraID.TabIndex = 7;
            // 
            // MostraCpfCNPJ
            // 
            this.MostraCpfCNPJ.FormattingEnabled = true;
            this.MostraCpfCNPJ.Location = new System.Drawing.Point(10, 139);
            this.MostraCpfCNPJ.Name = "MostraCpfCNPJ";
            this.MostraCpfCNPJ.Size = new System.Drawing.Size(164, 21);
            this.MostraCpfCNPJ.TabIndex = 6;
            // 
            // SenhaLogin
            // 
            this.SenhaLogin.AcceptsTab = true;
            this.SenhaLogin.Location = new System.Drawing.Point(213, 31);
            this.SenhaLogin.Name = "SenhaLogin";
            this.SenhaLogin.PasswordChar = '*';
            this.SenhaLogin.Size = new System.Drawing.Size(164, 20);
            this.SenhaLogin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "SENHA PARA DESBLOQUEIO";
            // 
            // FecharLogin
            // 
            this.FecharLogin.AllowDrop = true;
            this.FecharLogin.Location = new System.Drawing.Point(302, 57);
            this.FecharLogin.Name = "FecharLogin";
            this.FecharLogin.Size = new System.Drawing.Size(75, 23);
            this.FecharLogin.TabIndex = 4;
            this.FecharLogin.Text = "Sair";
            this.FecharLogin.UseVisualStyleBackColor = true;
            this.FecharLogin.Click += new System.EventHandler(this.FecharLogin_Click);
            // 
            // FazerLogin
            // 
            this.FazerLogin.Location = new System.Drawing.Point(213, 57);
            this.FazerLogin.Name = "FazerLogin";
            this.FazerLogin.Size = new System.Drawing.Size(75, 23);
            this.FazerLogin.TabIndex = 6;
            this.FazerLogin.Text = "Entrar";
            this.FazerLogin.UseVisualStyleBackColor = true;
            this.FazerLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // DesativaAmbiente
            // 
            this.DesativaAmbiente.Location = new System.Drawing.Point(356, 83);
            this.DesativaAmbiente.Name = "DesativaAmbiente";
            this.DesativaAmbiente.Size = new System.Drawing.Size(157, 23);
            this.DesativaAmbiente.TabIndex = 10;
            this.DesativaAmbiente.Text = "DESATIVAR AMBIENTE";
            this.DesativaAmbiente.UseVisualStyleBackColor = true;
            this.DesativaAmbiente.Click += new System.EventHandler(this.DesativaAmbiente_Click);
            // 
            // SenhaDelete
            // 
            this.SenhaDelete.Location = new System.Drawing.Point(356, 26);
            this.SenhaDelete.Name = "SenhaDelete";
            this.SenhaDelete.PasswordChar = '*';
            this.SenhaDelete.Size = new System.Drawing.Size(157, 20);
            this.SenhaDelete.TabIndex = 11;
            // 
            // EntrarDelete
            // 
            this.EntrarDelete.Location = new System.Drawing.Point(356, 52);
            this.EntrarDelete.Name = "EntrarDelete";
            this.EntrarDelete.Size = new System.Drawing.Size(75, 23);
            this.EntrarDelete.TabIndex = 12;
            this.EntrarDelete.Text = "Entrar";
            this.EntrarDelete.UseVisualStyleBackColor = true;
            this.EntrarDelete.Click += new System.EventHandler(this.EntrarDelete_Click);
            // 
            // SairDelete
            // 
            this.SairDelete.Location = new System.Drawing.Point(438, 52);
            this.SairDelete.Name = "SairDelete";
            this.SairDelete.Size = new System.Drawing.Size(75, 23);
            this.SairDelete.TabIndex = 13;
            this.SairDelete.Text = "Sair";
            this.SairDelete.UseVisualStyleBackColor = true;
            this.SairDelete.Click += new System.EventHandler(this.SairDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DESATIVAR AMBIENTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 390);
            this.Controls.Add(this.FazerLogin);
            this.Controls.Add(this.FecharLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SenhaLogin);
            this.Controls.Add(this.PainelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PainelMenu.ResumeLayout(false);
            this.PainelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CpfCnpjBanco;
        private System.Windows.Forms.Button MostrarAmbiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MostraRazaoSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MostraID;
        private System.Windows.Forms.ComboBox MostraCpfCNPJ;
        private System.Windows.Forms.TextBox SenhaLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FecharLogin;
        private System.Windows.Forms.Button FazerLogin;
        private System.Windows.Forms.Button DesativaAmbiente;
        private System.Windows.Forms.Button SairDelete;
        private System.Windows.Forms.Button EntrarDelete;
        private System.Windows.Forms.TextBox SenhaDelete;
        private System.Windows.Forms.Label label6;
    }
}

