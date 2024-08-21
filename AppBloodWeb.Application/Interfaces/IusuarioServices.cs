using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Domain.Interfaces;

namespace AppBloodWeb.Application.Interfaces;

    public interface IusuarioServices 
    
    {
        Task <IEnumerable<UsuarioDTO>> BuscarUsuario();
    }




