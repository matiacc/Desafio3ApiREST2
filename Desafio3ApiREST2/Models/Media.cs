using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio3ApiREST2.Models
{
    public class Media
    {
        public int Id { get; set; }
        public Tamanio Size { get; set; }
        public string Nombre { get; set; }
        public string Path { get; set; }
    }
}