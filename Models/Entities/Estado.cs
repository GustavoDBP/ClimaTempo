using System.ComponentModel.DataAnnotations;

namespace ClimaTempo.Models.Entities
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
