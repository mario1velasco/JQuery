using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JQuery.Domain.Entities
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int ID { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Municipio { get; set; }
        public string NIF { get; set; }
    }
}
