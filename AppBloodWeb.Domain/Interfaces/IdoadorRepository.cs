
using AppBloodWeb.Domain.Entities;
namespace AppBloodWeb.Domain.Interfaces;


public interface IdoadorRepository
{

    Task <IEnumerable <DoadorModel>> GetDoadorModel();

}