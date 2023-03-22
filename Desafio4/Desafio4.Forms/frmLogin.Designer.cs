
namespace Desafio4.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblUsuarioObg = new System.Windows.Forms.Label();
            this.lblSenhaObg = new System.Windows.Forms.Label();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 26);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário :";
            this.lblUsuario.UseWaitCursor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(12, 61);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(81, 26);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.UseWaitCursor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(17, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.UseWaitCursor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(17, 90);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(221, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseWaitCursor = true;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(163, 116);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.UseWaitCursor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblUsuarioObg
            // 
            this.lblUsuarioObg.AutoSize = true;
            this.lblUsuarioObg.ForeColor = System.Drawing.Color.Red;
            this.lblUsuarioObg.Location = new System.Drawing.Point(111, 18);
            this.lblUsuarioObg.Name = "lblUsuarioObg";
            this.lblUsuarioObg.Size = new System.Drawing.Size(11, 13);
            this.lblUsuarioObg.TabIndex = 5;
            this.lblUsuarioObg.Text = "*";
            this.lblUsuarioObg.UseWaitCursor = true;
            this.lblUsuarioObg.Visible = false;
            // 
            // lblSenhaObg
            // 
            this.lblSenhaObg.AutoSize = true;
            this.lblSenhaObg.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaObg.Location = new System.Drawing.Point(99, 70);
            this.lblSenhaObg.Name = "lblSenhaObg";
            this.lblSenhaObg.Size = new System.Drawing.Size(11, 13);
            this.lblSenhaObg.TabIndex = 6;
            this.lblSenhaObg.Text = "*";
            this.lblSenhaObg.UseWaitCursor = true;
            this.lblSenhaObg.Visible = false;
            // 
            // linkCadastro
            // 
            this.linkCadastro.AutoSize = true;
            this.linkCadastro.Location = new System.Drawing.Point(14, 121);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(59, 13);
            this.linkCadastro.TabIndex = 7;
            this.linkCadastro.TabStop = true;
            this.linkCadastro.Text = "Criar Conta";
            this.linkCadastro.UseWaitCursor = true;
            this.linkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(249, 146);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.lblSenhaObg);
            this.Controls.Add(this.lblUsuarioObg);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lblUsuarioObg;
        private System.Windows.Forms.Label lblSenhaObg;
        private System.Windows.Forms.LinkLabel linkCadastro;
    }
}

