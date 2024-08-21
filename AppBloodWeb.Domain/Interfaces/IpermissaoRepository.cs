
using AppBloodWeb.Domain.Entities;
namespace AppBloodWeb.Domain.Interfaces;


public interface IpermissaoRepository 
{

Task<IEnumerable<PermissaoModel>> GetPermissaoModel();

}