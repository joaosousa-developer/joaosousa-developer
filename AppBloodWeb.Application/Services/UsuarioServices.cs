using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Domain.Interfaces;


using AutoMapper;

namespace AppBloodWeb.Application.Services;


public class UsuarioServices : IusuarioServices

{
     private readonly IusuarioRepository _iusuarioRepository;
     private readonly IMapper _map;
     public UsuarioServices(IusuarioRepository userepository, IMapper map)
    {
        _iusuarioRepository = userepository;
        _map = map;
    }




    public async Task<IEnumerable<UsuarioDTO>> BuscarUsuario()
    {
          var bpermissaodto = await _iusuarioRepository.GetUsuarioModel();

          var permissaodto = _map.Map<IEnumerable<UsuarioDTO>>(bpermissaodto);

          return  permissaodto;
    }
   
}