using Microsoft.AspNetCore.Mvc;
using ProEventos.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public EventoController()
    {
       
    }

    [HttpGet]
    public Evento Get()
    {
       return new Evento(){
            EventoId = 1,
            Tema = "Angular",
            Local = "Brasil",
            Lote = "Lote 1",
            QtdPessoas = 1,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemUrl = "foto.png"
       };
    }

    [HttpPost]
    public string Post()
    {
       return "value Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
       return $"value {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
       return $"value {id}";
    }
}
