
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppBloodWeb.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace AppBloodWeb.Infrastructure.Repositories;

public class TriagemRepository : ItriagemRepository

{


private readonly AppDbContext  _context;


    public TriagemRepository(AppDbContext contexto){

      _context = contexto;


}

    public async Task<IEnumerable<TriagemModel>> GetBuscarTriagem()
    {
        
        var permitidos = await _context.triagemodel.ToListAsync();
        
        return permitidos;
    }

   
}