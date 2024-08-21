using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Domain.Interfaces;

namespace AppBloodWeb.Application.Interfaces;

   public interface  IpermissaoServices 
  
  {
      Task <IEnumerable<PermissaoDTO>> BuscarPermissao();


  }
   


