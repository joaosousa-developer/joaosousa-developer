
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Domain.Interfaces;
using AppBloodWeb.Infrastructure.Context;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
namespace AppBloodWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        //injeccao da interface para acessar os metodos do repositorio
        
        private readonly IAgendaServices _agendaServices;

        public AgendaController(IAgendaServices agendaServices)
        {
            _agendaServices = agendaServices;
        }

        // GET: api/<PermissaoController>
        [HttpGet("VerAgendas")]
        public async Task<ActionResult <IEnumerable<AgendaDTO>>> Get()
        {

            var agenda = await  _agendaServices.BuscarAgenda();
 
           // var  permissaodto = _imap.Map<IEnumerable<PermissaoDTO>>(permissao);

            return Ok(agenda);

        }     
      
    }
}
