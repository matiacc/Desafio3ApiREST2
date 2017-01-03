using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio3ApiREST2.Models
{
    public enum FormatosImagen
    {
        BMP,
        JPG,
        PNG
    }

    public class Imagen : Media
    {
        public FormatosImagen Formato { get; set; }
    }
}