using Desafio2.DataAccess.GenericAbstract;
using Desafio2.DomainModel.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio4.Forms
{
    public partial class frmCadastro : Form
    {
        frmLogin login = new frmLogin();
        Repositorio repositorio = new Repositorio();

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {   
            login.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCampos())
                {
                    if (!txtSenha.Text.Equals(txtConfSenha.Text))
                        throw new Exception("As senhas não são iguais");

                    Usuario usuario = new Usuario()
                    {
                        Login = txtUsuario.Text.ToLower(),
                        Email = txtEmail.Text.ToLower(),
                        Senha = txtSenha.Text,
                        Ativo = false,
                        DataCadastro = DateTime.Now,
                        DataAtualizacao = DateTime.Now
                    };
                    usuario.Validar();
                    repositorio.Usuario.Salvar(usuario);
                    repositorio.SaveChanges();
                    MessageBox.Show("Novo Usúario cadastro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCancelar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidaCampos() 
        {
            lblUseObg.Visible = string.IsNullOrEmpty(txtUsuario.Text) ? true : false;
            lblEmailObg.Visible = string.IsNullOrEmpty(txtEmail.Text) ? true : false;
            lblSenhaObg.Visible = string.IsNullOrEmpty(txtSenha.Text) ? true : false;
            lblConfSenhaObg.Visible = string.IsNullOrEmpty(txtConfSenha.Text) ? true : false;
            if (lblUseObg.Visible.Equals(true) || lblEmailObg.Visible.Equals(true) || 
                lblSenhaObg.Visible.Equals(true) || lblConfSenhaObg.Visible.Equals(true))
                return true;
            return false;
        }
    }
}
