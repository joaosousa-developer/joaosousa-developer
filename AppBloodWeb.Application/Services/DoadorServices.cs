using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Domain.Interfaces;


using AutoMapper;

namespace AppBloodWeb.Application.Services;


public class DoadorServices : IdoadorServices

{
     private readonly IdoadorRepository   _idoadorRepository;
     private readonly IMapper _map;
    public DoadorServices(IdoadorRepository  idoadorRepository, IMapper map)
    {
         _idoadorRepository =  idoadorRepository;
        _map = map;
    }

    public async Task<IEnumerable<DoadorDTO>> BuscarDoador()
    {
        var buscar = await _idoadorRepository.GetDoadorModel();

        var buscado = _map.Map<IEnumerable<DoadorDTO>>(buscar);

        return buscado;
    }

   

}