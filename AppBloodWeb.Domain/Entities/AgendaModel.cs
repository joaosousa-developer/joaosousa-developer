using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AppBloodWeb.Domain.Entities
{
    [Table("Agenda")]

   
        public class AgendaModel
    {
        [Key]
        [Required]
            public int IdAgenda { get; set; } // ID exclusivo para cada entrada na agenda  
            public DateTime Data { get; set; } // Data específica para a doação
            [ForeignKey("IdDoador")] // Indica que IdDoador é uma chave estrangeira
            public int IdDoador { get; set; }

        [JsonIgnore]
        public DoadorModel? doadormodel { get; set; }

       
        // Outras propriedades relevantes podem ser adicionadas conforme necessário

        // aqui na agenda/aplicativo/historicos podera ver a proxima data agendada para proxima doacao onde vai poder editar ou cancelar....
    }

    // O doador pode CANCELAR(excluir os dados da agenda),REMARCAR.(editar os dados da agenda)
}
