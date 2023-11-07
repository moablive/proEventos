using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] 
        {
            new Evento() {
                EventoId = 1,    
                Local = "POA RS",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Tema = "Angular e .NET",
                QtdPessoas = 200,
                Lote = "1 LOTE",
                ImagemURL = "foto.png"    
            } ,
            new Evento() {
                EventoId = 2,
                Local = "Santa Catarina SC",
                DataEvento = DateTime.Now.AddDays(4).ToString(),
                Tema = "Angular e .NET",
                QtdPessoas = 400,
                Lote = "1 LOTE",
                ImagemURL = "foto.png"
            }     
        };

        public EventoController()
        {  
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        { 
            return _evento;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        { 
            return _evento.Where(e => e.EventoId == id);
        }
    }
}
