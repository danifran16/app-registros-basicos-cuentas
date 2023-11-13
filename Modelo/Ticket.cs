using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Ticket
    {
        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public string? Producto { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
        private DateTime? _createdAt { get; set; } = DateTime.Now;
    }
}
