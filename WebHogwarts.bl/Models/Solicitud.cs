using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHogwarts_bl.Models
{
    [Table("solicitud", Schema = "dbo")]
    public class Solicitud
    {      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Int16 edad { get; set; }
        public string casa_afiliada { get; set; }
    }
}
