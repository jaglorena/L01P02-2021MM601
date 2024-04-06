using System.ComponentModel.DataAnnotations;

namespace L01P02_2021MM601.Models
{
    public class Departamentos
    {
        [Key]
        public int id { get; set; }
        public string departamento { get; set; }

    }
}
