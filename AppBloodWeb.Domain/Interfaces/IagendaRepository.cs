
using AppBloodWeb.Domain.Entities;
namespace AppBloodWeb.Domain.Interfaces;


public interface IagendaRepository
{

    Task <IEnumerable <AgendaModel>> GetAgendaModel();

}