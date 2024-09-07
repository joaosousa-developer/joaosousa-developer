
using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppBloodWeb.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace AppBloodWeb.Infrastructure.Repositories;

public class AgendaRepository: IagendaRepository

{


 private readonly AppDbContext  _Context;

 public AgendaRepository(AppDbContext contexto){

 _Context = contexto;


}

    public async Task <IEnumerable<AgendaModel>> GetAgendaModel()
    {
          var agend = await _Context.agendamodel.ToListAsync();

        return agend;
    }

    
}