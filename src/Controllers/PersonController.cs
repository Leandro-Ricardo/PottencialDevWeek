using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{

    [HttpGet]
    public Pessoa Get()
    {
        Pessoa pessoa = new Pessoa("Leandro", 33, "12345678");
        Contrato NovoContrato = new Contrato("abc123", 50.46);

        pessoa.Contratos.Add(NovoContrato);


        return pessoa;
    }

    [HttpPost]
    public Pessoa Post([FromBody]Pessoa pessoa)
    {
        return pessoa;
    }

    [HttpPut("{id}")]
    public string Update([FromRoute]int id, [FromBody]Pessoa pessoa)
    {
        Console.WriteLine(id);
        Console.WriteLine(pessoa);
        return "Dados do id " + id + " atualizados";
    }

[HttpDelete("{id}")]
public string Delete([FromRoute]int id){
return "Deletado pessoa de ID " + id;
}
}

