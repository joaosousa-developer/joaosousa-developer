
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
    public class PermissaoController : ControllerBase
    {
        //injeccao da interface para acessar os metodos do repositorio
        
        private IpermissaoServices _permissaoservices;
        public PermissaoController(IpermissaoServices permissaoservices)
        {
            
            _permissaoservices = permissaoservices;
        
        }
        // GET: api/<PermissaoController>
        [HttpGet("obterspermissoes")]
        public async Task<ActionResult<IEnumerable<PermissaoDTO>>> Get()
        {

            var permissao = await  _permissaoservices.BuscarPermissao();

           // var  permissaodto = _imap.Map<IEnumerable<PermissaoDTO>>(permissao);

            return Ok(permissao);

        }     
      
    }
}
