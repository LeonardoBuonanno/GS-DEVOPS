using GS.Models;
using System.Collections.Generic;
using System.Linq;

namespace GS.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly Contexto _contexto;

        public ClienteRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<Cliente> ListarTodos()
        {
            var listaCliente = _contexto
                .Cliente
                .ToList()
                .OrderBy(x => x.Email) // Alterado para ordenar por email
                .ToList();

            return listaCliente;
        }

        public Cliente ObterUm(int id)
        {
            var cliente = _contexto.Cliente.FirstOrDefault(x => x.Id == id);

            return cliente;
        }

        public Cliente SalvarCliente(Cliente model)
        {
            _contexto.Cliente.Add(model);
            _contexto.SaveChanges();

            return model;
        }

        public Cliente EditarCliente(int id, Cliente model)
        {
            var cliente = _contexto
                .Cliente
                .FirstOrDefault(x => x.Id == id);

            if (cliente is not null)
            {
                //Faz o de-para dos valores para atualizar a base de dados
                cliente.Nome = model.Nome;
                cliente.Email = model.Email; // Alterado para atualizar o email

                _contexto.Cliente.Update(cliente);
                _contexto.SaveChanges();

                return cliente;
            }

            return model;
        }

        public Cliente ExcluirCliente(int id)
        {
            var cliente = _contexto
                .Cliente
                .FirstOrDefault(x => x.Id == id);

            if (cliente is not null)
            {
                _contexto.Cliente.Remove(cliente);
                _contexto.SaveChanges();

                return cliente;
            }

            //Retorna um cliente vazio, caso nao encontre nenhum registro
            return new Cliente();
        }
    }
}
