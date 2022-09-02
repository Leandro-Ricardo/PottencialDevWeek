using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Persistence;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private DatabaseContext _context { get; set; }

    public PersonController(DatabaseContext context)
    {
        this._context = context;
    }

    [HttpGet]
    public List<Pessoa> Get()
    {
        // Pessoa pessoa = new Pessoa("Leandro", 33, "12345678");
        // Contrato NovoContrato = new Contrato("abc123", 50.46);

        //  pessoa.Contratos.Add(NovoContrato);
        return _context.Pessoas.Include(p => p.Contratos).ToList();
        
    }

    [HttpPost]
    public Pessoa Post([FromBody] Pessoa pessoa)
    {
        _context.Pessoas.Add(pessoa);
        _context.SaveChanges();

        return pessoa;
    }

    [HttpPut("{id}")]
    public string Update([FromRoute] int id, [FromBody] Pessoa pessoa)
    {
        _context.Pessoas.Update(pessoa);
        _context.SaveChanges();
        return "Dados do id " + id + " atualizados";
    }

    [HttpDelete("{id}")]
    public string Delete([FromRoute] int id)
    {
        return "Deletado pessoa de ID " + id;
    }
}

