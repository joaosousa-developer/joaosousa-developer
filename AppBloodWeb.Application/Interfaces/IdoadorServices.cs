using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Domain.Interfaces;



namespace AppBloodWeb.Application.Interfaces;

   public interface  IdoadorServices
  
  {
     Task <IEnumerable <DoadorDTO>> BuscarDoador();

  }
   


