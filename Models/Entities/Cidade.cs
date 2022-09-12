using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ClimaTempo.Models.Entities
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId{ get; set; }

        public virtual Estado Estado { get; set; }
    }
}
