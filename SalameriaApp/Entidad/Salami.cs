using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalameriaApp.Entidad
{
    public class Salami
    {
        [Key]
        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int Precio { get; set; }

        public Salami()
        {
            Numero = 0;
            Descripcion = string.Empty;
            Tipo = string.Empty;
            Precio = 0;
        }

        public Salami(int salamiId, string descripcion, string tipo, int precio)
        {
            Numero = salamiId;
            Descripcion = descripcion;
            Tipo = tipo;
            Precio = precio;
        }
    }
}
