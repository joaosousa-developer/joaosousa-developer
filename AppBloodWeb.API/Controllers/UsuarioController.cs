
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Application.Services;
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
    public class UsuarioController : ControllerBase
    {
        //injeccao da interface para acessar os metodos do repositorio
        
        private IusuarioServices _usuarioServices;
        public UsuarioController(IusuarioServices iusuarioServices)
        {
            
           _usuarioServices = iusuarioServices;
        
        }
        // GET: api/<PermissaozController>
        [HttpGet("obterusuarios")]
        public async Task<ActionResult<IEnumerable<UsuarioDTO>>> Get()
        {

            var permissao = await _usuarioServices.BuscarUsuario();

           // var  permissaodto = _imap.Map<IEnumerable<PermissaoDTO>>(permissao);

            return Ok(permissao);

        }
       
      
    }
}
