using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio3ApiREST2.Models
{
    public class Video : Media
    {
        public int Duracion { get; set; }
        public enum Formato
        {
            MP4,
            AVI,
            FLW
        }
    }
}