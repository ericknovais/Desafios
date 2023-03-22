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
    public partial class frmLogin : Form
    {
        Repositorio repositorio = new Repositorio();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Logar()
        {
            IList<Usuario> usuario = repositorio.Usuario.UsuarioExiste(txtUsuario.Text.ToLower(), txtSenha.Text.ToLower());
            if (usuario.Count == 0)
            {
                MessageBox.Show("Usúario ou senha invalidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpaSenha();
                return;
            }

            if (usuario.First().Ativo.Equals(false))
            {
                MessageBox.Show("Usuário Inativo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpaSenha();
                return;
            }

            Program.UsuarioLogado = usuario.First().Login;
            frmDefault frmDefault = new frmDefault();
            frmDefault.Show();
            this.Visible = false;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioObg.Visible = string.IsNullOrWhiteSpace(txtUsuario.Text) ? true : false;
                lblSenhaObg.Visible = string.IsNullOrWhiteSpace(txtSenha.Text) ? true : false;

                if (lblUsuarioObg.Visible.Equals(true) || lblSenhaObg.Visible.Equals(true))
                    return;

                Logar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpaSenha()
        {
            txtSenha.Text = string.Empty;
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
            this.Visible = false;
        }
    }
}
