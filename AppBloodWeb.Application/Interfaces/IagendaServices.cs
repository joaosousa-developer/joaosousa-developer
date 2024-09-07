using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Domain.Interfaces;



namespace AppBloodWeb.Application.Interfaces;

   public interface  IAgendaServices
  
  {
     Task <IEnumerable <AgendaDTO>> BuscarAgenda();

  }
   


