using GS.Models;

namespace GS.Repository
{
    public interface IClienteRepository
    {
        List<Cliente> ListarTodos();
        Cliente ObterUm(int id);
        Cliente SalvarCliente(Cliente model);
        Cliente EditarCliente(int id, Cliente model);
        Cliente ExcluirCliente(int id);

    }
}

