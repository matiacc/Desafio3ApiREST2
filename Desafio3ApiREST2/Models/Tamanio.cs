using System;
using System.Collections.Generic;
#if !CONSOLE_APP
using System.ComponentModel.DataAnnotations.Schema;
#endif
using System.Linq;
using System.Web;

namespace Desafio3ApiREST2.Models
{
#if !CONSOLE_APP
    [ComplexType]//No crea una tabla con esta clase
#endif
    public class Tamanio
    {
        public int Width { get; set; }
        public int Heigh { get; set; }
    }
}