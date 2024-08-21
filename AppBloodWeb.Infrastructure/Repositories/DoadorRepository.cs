
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppBloodWeb.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace AppBloodWeb.Infrastructure.Repositories;

public class DoadorRepository: IdoadorRepository

{


 private readonly AppDbContext  _Context;

 public DoadorRepository(AppDbContext contexto){

 _Context = contexto;


}


    public async Task<IEnumerable<DoadorModel>> GetDoadorModel()
    {
        
        var doador = await _Context.doadormodel.ToListAsync();
        
        return doador;
    }
}