
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppBloodWeb.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace AppBloodWeb.Infrastructure.Repositories;

public class PermissaoRepository : IpermissaoRepository

{


private readonly AppDbContext  _Context;

public PermissaoRepository(AppDbContext contexto){

_Context = contexto;


}


    public async Task<IEnumerable<PermissaoModel>> GetPermissaoModel()
    {
        
        var permitidos = await _Context.permissaomodel.ToListAsync();
        
        return permitidos;
    }
}