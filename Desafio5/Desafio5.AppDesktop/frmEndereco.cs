using DataModel.Desafio5.model;
using Desafio5.DataAccess.repository;
using Desafio5.DataModel.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Desafio5.AppDesktop
{
    public partial class frmEndereco : Form
    {
        Repository repository = new Repository();
        Estado estadoSelecionado;
        Cidade cidadeSelecionada;

        public frmEndereco()
        {
            InitializeComponent();
            cbxEstado.Items.Insert(0, "Selecione Estado");
            cbxEstado.SelectedIndex = 0;
            CarregaComboBoxEstado();
            SetComboCidade();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                    throw new Exception("A campos obrigatorios!");

                estadoSelecionado = (Estado)cbxEstado.SelectedItem;
                cidadeSelecionada = (Cidade)cbxCidade.SelectedItem;
                Endereco endereco = new Endereco()
                {
                    CEP = mkTxtCEP.Text,
                    Bairro = txtBairro.Text,
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                    Complemento = string.IsNullOrWhiteSpace(txtComplemento.Text) ? " " : txtComplemento.Text,
                    Estado = estadoSelecionado.Nome,
                    Cidade = cidadeSelecionada.Nome,
                    DataCriacao = DateTime.Now,
                    DataAtualizacao = DateTime.Now
                };

                endereco.Validar();
                repository.Endereco.Salvar(endereco);
                repository.SaveChanges();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cbxEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            estadoSelecionado = (Estado)cbxEstado.SelectedItem;
            SetComboCidade();
            if (!estadoSelecionado.ID.Equals(0))
                CarregaComboCidade(estadoSelecionado);
        }

        private bool ValidaCampos()
        {
            estadoSelecionado = (Estado)cbxEstado.SelectedItem;
            cidadeSelecionada = (Cidade)cbxCidade.SelectedItem;

            lblMgsCEP.Visible = mkTxtCEP.Text.Equals("     -") ? true : false;
            lblMgsBairro.Visible = string.IsNullOrEmpty(txtBairro.Text) ? true : false;
            lblMgsLogradouro.Visible = string.IsNullOrEmpty(txtLogradouro.Text) ? true : false;
            lblMgsNumero.Visible = string.IsNullOrEmpty(txtNumero.Text) ? true : false;
            lblMgsEstado.Visible = estadoSelecionado.ID.Equals(0) ? true : false;
            lblMgsCidade.Visible = cidadeSelecionada.ID.Equals(0) ? true : false;

            if (lblMgsCEP.Visible.Equals(true) || lblMgsBairro.Visible.Equals(true) ||
                lblMgsLogradouro.Visible.Equals(true) || lblMgsNumero.Visible.Equals(true) ||
                lblMgsEstado.Visible.Equals(true) || lblMgsCidade.Visible.Equals(true))
                return true;
            return false;
        }

        private void LimparCampos()
        {
            mkTxtCEP.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cbxEstado.SelectedIndex = 0;
            SetComboCidade();
            MessageBox.Show("Novo endereço cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private async void CarregaComboBoxEstado()
        {
            try
            {
                List<Estado> estados = new List<Estado>() { new Estado() { ID = 0, Nome = "Selecione Estado", Sigla = "nn" } };
                HttpClient httpClient = new HttpClient();
                estados.AddRange(
                        JsonConvert.DeserializeObject<List<Estado>>
                            (await httpClient.GetStringAsync("https://servicodados.ibge.gov.br/api/v1/localidades/estados")).
                            OrderBy(x => x.Nome).ToList());
                cbxEstado.DataSource = estados;
                cbxEstado.DisplayMember = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void CarregaComboCidade(Estado estado)
        {
            try
            {
                List<Cidade> cidades = new List<Cidade>() { new Cidade() { ID = 0, Nome = "Selecione Cidade" } };
                HttpClient httpClient = new HttpClient();
                cidades.AddRange(
                    JsonConvert.DeserializeObject<List<Cidade>>
                        (await httpClient.GetStringAsync($"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{estado.Sigla}/municipios"))
                        .OrderBy(x => x.Nome).ToList());
                cbxCidade.DataSource = cidades;
                cbxCidade.DisplayMember = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetComboCidade()
        {
            cbxCidade.DataSource = new List<Cidade>() { new Cidade() { ID = 0, Nome = "Selecione Cidade" } };
            cbxCidade.DisplayMember = "Nome";
        }
    }
}
