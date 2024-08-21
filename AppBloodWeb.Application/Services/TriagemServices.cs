
using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Domain.Interfaces;
using AppBloodWeb.Domain.Entities;
using AutoMapper;

namespace AppBloodWeb.Application.Services;
public class TriagemServices : ItriagemServices

{   

    private readonly ItriagemRepository _itriagemrepository;

    private readonly IMapper _map;

    public TriagemServices(ItriagemRepository itriagemrepository , IMapper map)
    {
        _itriagemrepository = itriagemrepository;
        _map = map;
    }


   

      async  Task<IEnumerable<TriagemDTO>> ItriagemServices.BuscarTriagem()
    {
         var chamarmodel = await _itriagemrepository.GetBuscarTriagem();

           var buscartriagem = _map.Map<IEnumerable<TriagemDTO>>(chamarmodel);

           return buscartriagem;
    }
}