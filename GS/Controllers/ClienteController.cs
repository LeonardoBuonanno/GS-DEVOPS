using GS.Models;
using Microsoft.AspNetCore.Mvc;


public class ClienteController : Controller
{
    private readonly Contexto _contexto;

    public ClienteController(Contexto contexto)
    {
        _contexto = contexto;
    }

    public IActionResult ListarTodos()
    {
        var clientes = _contexto.Cliente.ToList();

        return Json(clientes);
    }

    public IActionResult ListarUm()
    {
       
        var cliente = _contexto.Cliente.Where(x => x.Email == "@fiap.com.br").FirstOrDefault();

        return Json(cliente);

    }

    public IActionResult Inserir()
    {
        var model = new Cliente();

        model.Nome = "Leonardo";
        model.Email = "Leonardo@gmail.com"; 

        _contexto.Cliente.Add(model);
        _contexto.SaveChanges();

        return Json(new { });
    }


    public IActionResult Alterar()
    {
        var model = _contexto.Cliente.Find(1);

        model.Nome = "Victor";

        _contexto.Cliente.Update(model);
        _contexto.SaveChanges();


        return Json(model);
    }

    public IActionResult Delete()
    {
        var model = _contexto.Cliente.Find(1);

        //Delete from tb_cliente where id = 1 

        _contexto.Cliente.Remove(model);
        _contexto.SaveChanges();


        return Json(model);
    }
}