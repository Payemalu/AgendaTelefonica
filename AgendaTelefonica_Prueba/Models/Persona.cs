using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica_Prueba.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Direccion> Direcciones { get; set; }
    }
}
