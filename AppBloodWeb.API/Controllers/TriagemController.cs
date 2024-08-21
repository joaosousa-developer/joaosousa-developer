using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Domain.Interfaces;
using AppBloodWeb.Infrastructure.Context;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;



namespace AppBloodWeb.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TriagemController : ControllerBase
    {
       private readonly ItriagemServices _itriagemservices;

       public TriagemController (ItriagemServices itriagemservices)
       {
           _itriagemservices = itriagemservices;;
        
       }


       
        [HttpGet("BuscarUser")]
        public async Task <ActionResult<IEnumerable<TriagemDTO>>> Get(){

           var buscaruser = await _itriagemservices.BuscarTriagem();

           return Ok(buscaruser);

        }

    }




}