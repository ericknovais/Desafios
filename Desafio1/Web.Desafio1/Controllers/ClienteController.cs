using DataAccess.Desafio1.Generico;
using DomainModel.Desafio1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Desafio1.ViewModels;

namespace Web.Desafio1.Controllers
{
    public class ClienteController : Controller
    {
        #region Repositorio
        Repositorio repositorio = new Repositorio();
        #endregion

        public ActionResult List()
        {
            try
            {
                return View(repositorio.Cliente.ObterTodos());
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new List<Cliente>());
            }
        }

        public ActionResult Edit(int id = 0)
        {
            try
            {
                EnInclusao(id);
                ClienteViewModel model = id.Equals(0) ? new ClienteViewModel() : ObterClienteViewModel(id);
                return View(CarregarDropCidade(CarregarDropEstado(model)));
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new ClienteViewModel());
            }
        }

        [HttpPost]
        public ActionResult Edit(ClienteViewModel entidade, int id = 0)
        {
            try
            {
                if (entidade.EstadoID.Equals(0) || entidade.CidadeID.Equals(0))
                    return View(CarregarDropCidade(CarregarDropEstado(entidade)));

                var cpfExiste = repositorio.Cliente.ObterClientePorCPF(entidade.CPF);
                if (!cpfExiste.Count.Equals(0) && !entidade.ID.Equals(cpfExiste[0].ID))
                    throw new Exception($"O CPF: <b>{entidade.CPF}</b> já cadastrado no sistema.");

                Cliente cliente = ObterCliente(id);
                cliente.NomeCompleto = entidade.NomeCompleto;
                cliente.CPF = entidade.CPF;
                cliente.Email = entidade.Email.ToLower();
                cliente.DataNascimento = entidade.DataNascimento;
                cliente.DataCadastro = id.Equals(0) ? DateTime.Now : cliente.DataCadastro;
                cliente.DataAtualizacao = DateTime.Now;
                cliente.Validar();
                repositorio.Cliente.Salvar(cliente);

                Endereco endereco = ObterEnderecoPorIdCliente(cliente.ID);
                endereco.ClienteID = cliente.ID;
                endereco.Logradouro = entidade.Logradouro;
                endereco.Numero = entidade.Numero;
                endereco.CEP = entidade.CEP;
                endereco.Complemento = entidade.Complemento == null ? string.Empty : entidade.Complemento;
                endereco.Bairro = entidade.Bairro;
                endereco.Cidade = repositorio.Cidade.ObterPor(entidade.CidadeID);
                endereco.DataCadastro = id.Equals(0) ? DateTime.Now : cliente.DataCadastro;
                endereco.DataAtualizacao = DateTime.Now;
                endereco.Validar();
                repositorio.Endereco.Salvar(endereco);

                repositorio.SaveChanges();

                if (id.Equals(0))
                    return View(LimparTela());

                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(CarregarDropCidade(CarregarDropEstado(entidade)));
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Cliente cliente = ObterCliente(id);
                string nomeCliente = cliente.NomeCompleto;
                repositorio.Cliente.Excluir(cliente);
                repositorio.SaveChanges();
                TempData["Alerta"] = $"Cliente: <b>{nomeCliente}</b> foi excluido do sistema!";
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return RedirectToAction("List");
            }
        }


        #region Métodos Privados
        private ClienteViewModel ObterClienteViewModel(int id)
        {
            Cliente cliente = ObterCliente(id);
            Endereco endereco = ObterEnderecoPorIdCliente(cliente.ID);
            Estado estado = repositorio.Estado.ObterPor(repositorio.Cidade.ObterPor(endereco.CidadeID).EstadoID);

            ClienteViewModel clienteView = new ClienteViewModel()
            {
                NomeCompleto = cliente.NomeCompleto,
                CPF = cliente.CPF,
                DataNascimento = cliente.DataNascimento,
                Email = cliente.Email,
                CEP = endereco.CEP,
                Bairro = endereco.Bairro,
                Logradouro = endereco.Logradouro,
                Complemento = endereco.Complemento,
                Numero = endereco.Numero,
                CidadeID = endereco.CidadeID,
                EstadoID = estado.ID
            };

            return clienteView;
        }

        private Endereco ObterEnderecoPorIdCliente(int clienteID)
        {
            return clienteID.Equals(0) ? new Endereco() : repositorio.Endereco.ObterEnderecoPorClienteID(clienteID);
        }

        private void EnInclusao(int id)
        {
            TempData["EnInclusao"] = id.Equals(0) ? "Cadastro Cliente" : "Edição Cliente";
        }

        private void Alerta(Exception ex)
        {
            TempData["Alerta"] = ex.Message.Replace(Environment.NewLine, "</br>");
        }

        private Cliente ObterCliente(int id)
        {
            return id.Equals(0) ? new Cliente() : repositorio.Cliente.ObterPor(id);
        }

        private ClienteViewModel CarregarDropEstado(ClienteViewModel clienteView)
        {
            ViewBag.EstadoID = new SelectList
                (
                    repositorio.Estado.ObterTodos(),
                    "ID",
                    "Nome",
                    clienteView.EstadoID
                );
            return clienteView;
        }

        private ClienteViewModel CarregarDropCidade(ClienteViewModel clienteView)
        {
            ViewBag.CidadeID = new SelectList
                (
                    repositorio.Cidade.ObterCidadePorEstadoID(clienteView.EstadoID),
                    "ID",
                    "Nome",
                    clienteView.CidadeID
                );
            return clienteView;
        }

        private ClienteViewModel LimparTela()
        {
            TempData["Mensagem"] = "Sucesso";
            ModelState.Clear();
            EnInclusao(0);
            return CarregarDropCidade(CarregarDropEstado(new ClienteViewModel()));
        }

        #endregion
    }
}