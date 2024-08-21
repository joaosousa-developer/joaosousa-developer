
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
    public class DoadorController : ControllerBase
    {
        //injeccao da interface para acessar os metodos do repositorio
        
        private readonly IdoadorServices _idoadorServices;

        public DoadorController(IdoadorServices idoadorServices)
        {
            _idoadorServices = idoadorServices;
        }

        // GET: api/<PermissaoController>
        [HttpGet("obterspermissoes")]
        public async Task<ActionResult<IEnumerable<DoadorDTO>>> Get()
        {

            var doador = await  _idoadorServices.BuscarDoador();

           // var  permissaodto = _imap.Map<IEnumerable<PermissaoDTO>>(permissao);

            return Ok(doador);

        }     
      
    }
}
