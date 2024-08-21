
using AppBloodWeb.Domain.Entities;

namespace AppBloodWeb.Domain.Interfaces;

public interface IusuarioRepository
{
     Task <IEnumerable<UsuariosModel>> GetUsuarioModel();
    
}

