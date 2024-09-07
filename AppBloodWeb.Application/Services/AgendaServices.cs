using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Domain.Interfaces;


using AutoMapper;

namespace AppBloodWeb.Application.Services;


public class AgendaServices : IAgendaServices

{
     private readonly IagendaRepository _iagendaRepository;
     private readonly IMapper _map;
    public AgendaServices(IagendaRepository  iagendaRepository, IMapper map)
    {
        _iagendaRepository =  iagendaRepository;
        _map = map;
    }

   

    public async Task<IEnumerable<AgendaDTO>> BuscarAgenda()
    {
        var buscar = await _iagendaRepository.GetAgendaModel();

        var buscado = _map.Map<IEnumerable<AgendaDTO>>(buscar);

        return buscado;
    }
}