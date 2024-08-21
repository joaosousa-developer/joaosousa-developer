using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Domain.Interfaces;


using AutoMapper;

namespace AppBloodWeb.Application.Services;


public class PermissaoServices : IpermissaoServices

{
     private readonly IpermissaoRepository _ipermissaorepository;
     private readonly IMapper _map;
    public PermissaoServices(IpermissaoRepository ipermissaorepository, IMapper map)
    {
        _ipermissaorepository = ipermissaorepository;
        _map = map;
    }

    public async  Task<IEnumerable<PermissaoDTO>> BuscarPermissao()
    {
        var bpermissaodto = await _ipermissaorepository.GetPermissaoModel();


         var permissaodto = _map.Map<IEnumerable<PermissaoDTO>>(bpermissaodto);

          return  permissaodto;
    }

}