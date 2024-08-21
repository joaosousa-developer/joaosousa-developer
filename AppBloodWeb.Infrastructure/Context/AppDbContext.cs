using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;

using AppBloodWeb.Domain.Entities;

namespace AppBloodWeb.Infrastructure.Context
{

    public class AppDbContext : DbContext /*IdentityDbContext<ApplicationUser>*/

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;initial catalog=bancoclean;uid=root", ServerVersion.Parse("8.2.0-mysql"));
            }
        }
      




        public DbSet<DoadorModel> doadormodel { get; set; } // Adicione esta propriedade
        public DbSet<BolsaDeSangueModel> bolsadesangue { get; set; } // Adicione esta propriedade

        public DbSet<AgendaModel> agendamodel { get; set; }

        public DbSet<AdiministradorModel> adiministrador { get; set; }

        public DbSet<UsuariosModel> usuariomodel { get; set; }

        public DbSet<HistoricoDoadorModel> historicodoadormodel { get; set; }

        public DbSet<PermissaoModel> permissaomodel { get; set; }

        public DbSet<TriagemModel> triagemodel { get; set; }

        public DbSet<TriagemDetalhesModel> triagemdetalhesmodel { get; set; }

        public DbSet<TriagemAptidaoModel> triagemaptidaomodel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext)
               .Assembly);

            // Configurar chave primária para IdentityUser, se necessário
            //modelBuilder.Entity<IdentityUser>()
            //.HasKey(u => u.Id);



            modelBuilder.Entity<BolsaDeSangueModel>()
                .HasOne(bolsa => bolsa.doadormodel)
                .WithMany(doador => doador.bolsadesangue)
                .HasForeignKey(bolsa => bolsa.IdDoador)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuração do relacionamento um para um
            modelBuilder.Entity<AgendaModel>()
                .HasOne(agenda => agenda.doadormodel)
                .WithMany(doador => doador.agendamodel)
                .HasForeignKey(agenda => agenda.IdDoador)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HistoricoDoadorModel>()
           .HasOne(historico => historico.doadormodel)
           .WithMany(doador => doador.historicodoadormodel)
           .HasForeignKey(historico => historico.IdDoador)
           .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<AdiministradorModel>()
           .HasOne(adimin => adimin.usuariomodel)
           .WithMany(user => user.adiministrador)
           .HasForeignKey(adimin => adimin.Id)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UsuariosModel>()
                .HasOne(user => user.permissaomodel)
                .WithMany(permiti => permiti.usuariomodel)
                .HasForeignKey(user => user.Idpermissao)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DoadorModel>()
               .HasOne(doa => doa.usuariomodel)
               .WithMany(user => user.doadormodel)
               .HasForeignKey(doa => doa.Id)
              .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<TriagemModel>()
            .HasOne(t => t.doadormodel)
            .WithMany(d => d.triagemodel)
            .HasForeignKey(t => t.IdDoador) //muito para muito
            .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<TriagemModel>()
                .HasOne(t => t.triagemaptidaomodel)
                .WithOne(ta => ta.triagemodel)
                .HasForeignKey<TriagemAptidaoModel>(t => t.TriagemID) // um para um
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TriagemModel>()
              .HasOne(t => t.triagemdetalhesmodel)
              .WithOne(ta => ta.triagemodel)
              .HasForeignKey<TriagemDetalhesModel>(t => t.triagemId)
              .OnDelete(DeleteBehavior.Cascade);



        }

    }
}
