
namespace Desafio5.AppDesktop
{
    partial class frmEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEndereco));
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.lblMgsCEP = new System.Windows.Forms.Label();
            this.lblMgsBairro = new System.Windows.Forms.Label();
            this.lblMgsLogradouro = new System.Windows.Forms.Label();
            this.lblMgsNumero = new System.Windows.Forms.Label();
            this.lblMgsEstado = new System.Windows.Forms.Label();
            this.lblMgsCidade = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mkTxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(12, 9);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 20);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(12, 55);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(95, 20);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(16, 78);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(295, 20);
            this.txtLogradouro.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(12, 101);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(69, 20);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(16, 124);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(65, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(140, 9);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(144, 32);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(167, 20);
            this.txtBairro.TabIndex = 2;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(140, 101);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 20);
            this.lblComplemento.TabIndex = 8;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(144, 124);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(167, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(12, 147);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(12, 194);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(16, 170);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(295, 21);
            this.cbxEstado.TabIndex = 12;
            this.cbxEstado.SelectionChangeCommitted += new System.EventHandler(this.cbxEstado_SelectionChangeCommitted);
            // 
            // cbxCidade
            // 
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(16, 217);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(295, 21);
            this.cbxCidade.TabIndex = 13;
            // 
            // lblMgsCEP
            // 
            this.lblMgsCEP.AutoSize = true;
            this.lblMgsCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgsCEP.ForeColor = System.Drawing.Color.Red;
            this.lblMgsCEP.Location = new System.Drawing.Point(62, 12);
            this.lblMgsCEP.Name = "lblMgsCEP";
            this.lblMgsCEP.Size = new System.Drawing.Size(13, 16);
            this.lblMgsCEP.TabIndex = 14;
            this.lblMgsCEP.Text = "*";
            this.lblMgsCEP.Visible = false;
            // 
            // lblMgsBairro
            // 
            this.lblMgsBairro.AutoSize = true;
            this.lblMgsBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgsBairro.ForeColor = System.Drawing.Color.Red;
            this.lblMgsBairro.Location = new System.Drawing.Point(201, 12);
            this.lblMgsBairro.Name = "lblMgsBairro";
            this.lblMgsBairro.Size = new System.Drawing.Size(13, 16);
            this.lblMgsBairro.TabIndex = 15;
            this.lblMgsBairro.Text = "*";
            this.lblMgsBairro.Visible = false;
            // 
            // lblMgsLogradouro
            // 
            this.lblMgsLogradouro.AutoSize = true;
            this.lblMgsLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgsLogradouro.ForeColor = System.Drawing.Color.Red;
            this.lblMgsLogradouro.Location = new System.Drawing.Point(113, 58);
            this.lblMgsLogradouro.Name = "lblMgsLogradouro";
            this.lblMgsLogradouro.Size = new System.Drawing.Size(13, 16);
            this.lblMgsLogradouro.TabIndex = 16;
            this.lblMgsLogradouro.Text = "*";
            this.lblMgsLogradouro.Visible = false;
            // 
            // lblMgsNumero
            // 
            this.lblMgsNumero.AutoSize = true;
            this.lblMgsNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgsNumero.ForeColor = System.Drawing.Color.Red;
            this.lblMgsNumero.Location = new System.Drawing.Point(87, 104);
            this.lblMgsNumero.Name = "lblMgsNumero";
            this.lblMgsNumero.Size = new System.Drawing.Size(13, 16);
            this.lblMgsNumero.TabIndex = 17;
            this.lblMgsNumero.Text = "*";
            this.lblMgsNumero.Visible = false;
            // 
            // lblMgsEstado
            // 
            this.lblMgsEstado.AutoSize = true;
            this.lblMgsEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgsEstado.ForeColor = System.Drawing.Color.Red;
            this.lblMgsEstado.Location = new System.Drawing.Point(82, 150);
            this.lblMgsEstado.Name = "lblMgsEstado";
            this.lblMgsEstado.Size = new System.Drawing.Size(13, 16);
            this.lblMgsEstado.TabIndex = 19;
            this.lblMgsEstado.Text = "*";
            this.lblMgsEstado.Visible = false;
            // 
            // lblMgsCidade
            // 
            this.lblMgsCidade.AutoSize = true;
            this.lblMgsCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgsCidade.ForeColor = System.Drawing.Color.Red;
            this.lblMgsCidade.Location = new System.Drawing.Point(81, 197);
            this.lblMgsCidade.Name = "lblMgsCidade";
            this.lblMgsCidade.Size = new System.Drawing.Size(13, 16);
            this.lblMgsCidade.TabIndex = 20;
            this.lblMgsCidade.Text = "*";
            this.lblMgsCidade.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(236, 244);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mkTxtCEP
            // 
            this.mkTxtCEP.Location = new System.Drawing.Point(16, 31);
            this.mkTxtCEP.Mask = "00000-000";
            this.mkTxtCEP.Name = "mkTxtCEP";
            this.mkTxtCEP.Size = new System.Drawing.Size(110, 20);
            this.mkTxtCEP.TabIndex = 1;
            this.mkTxtCEP.Tag = "1";
            // 
            // frmEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 279);
            this.Controls.Add(this.mkTxtCEP);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblMgsCidade);
            this.Controls.Add(this.lblMgsEstado);
            this.Controls.Add(this.lblMgsNumero);
            this.Controls.Add(this.lblMgsLogradouro);
            this.Controls.Add(this.lblMgsBairro);
            this.Controls.Add(this.lblMgsCEP);
            this.Controls.Add(this.cbxCidade);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblCEP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Label lblMgsCEP;
        private System.Windows.Forms.Label lblMgsBairro;
        private System.Windows.Forms.Label lblMgsLogradouro;
        private System.Windows.Forms.Label lblMgsNumero;
        private System.Windows.Forms.Label lblMgsEstado;
        private System.Windows.Forms.Label lblMgsCidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mkTxtCEP;
    }
}

