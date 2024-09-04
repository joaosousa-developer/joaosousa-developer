using AppBloodWeb.Domain.Entities;
using AppBloodWeb.Application.DTOs;
using AutoMapper;

namespace AppBloodWeb.Application.Mapings;

    public class ModeloDToMappingsProfile: Profile
   {
        public ModeloDToMappingsProfile()
        {   


            CreateMap<PermissaoModel, PermissaoDTO>().ReverseMap();

//            CreateMap<TriagemAptidaoModel, TriagemAptidaoDTO>().ReverseMap();
            CreateMap<TriagemDetalhesModel,TriagemDetalhesDTO>().ReverseMap();
//            CreateMap<TriagemModel , TriagemDTO>().ReverseMap();
            CreateMap<UsuariosModel, UsuarioDTO>().ReverseMap();
 
//            CreateMap<HistoricoDoadorModel, HistoricoDTO>().ReverseMap();
            CreateMap<DoadorModel, DoadorDTO>().ReverseMap();
//            CreateMap<BolsaDeSangueModel, BolsaDTO>().ReverseMap();
           CreateMap<AgendaModel, AgendaDTO>().ReverseMap();
//            CreateMap<AdiministradorModel, AdiministradorDTO>().ReverseMap();


       }
    }

