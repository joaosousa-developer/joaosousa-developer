
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppBloodWeb.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace AppBloodWeb.Infrastructure.Repositories;

public class UsuarioRepository : IusuarioRepository

{


private readonly AppDbContext  _Context;

public UsuarioRepository(AppDbContext contexto){

_Context = contexto;


}

    public async Task<IEnumerable<UsuariosModel>> GetUsuarioModel()
    {
         var usuarios = await _Context.usuariomodel.ToListAsync();

         return usuarios;
    }

  
}



