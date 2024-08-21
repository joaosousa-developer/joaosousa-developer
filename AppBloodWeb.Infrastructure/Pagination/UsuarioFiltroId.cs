namespace AppBloodWeb.Infrastructure.Pagination;

// classe para receber daodos da consulta filtro do Usuario com a base criterio
// depois ajustamos a interface do usuario e do repositorio para preparar o metodo na controler
public class UsuarioFiltroId : QueryStringParameters
{
       public int ? Id { get; set; }
       public string? IdCriterio { get; set; } // "maior", "menor" ou "igual"
}
