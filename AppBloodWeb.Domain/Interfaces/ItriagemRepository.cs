
using AppBloodWeb.Domain.Entities;
namespace AppBloodWeb.Domain.Interfaces;


 public interface ItriagemRepository
  {

     Task <IEnumerable<TriagemModel>> GetBuscarTriagem();
  
 }




