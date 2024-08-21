using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Domain.Interfaces;

namespace AppBloodWeb.Application.Interfaces;

   public interface ItriagemServices 
   
   {
         Task <IEnumerable<TriagemDTO>> BuscarTriagem();

   }

