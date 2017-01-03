using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio3ApiREST2.Models
{
    public class Desafio3ApiREST2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Desafio3ApiREST2Context() : base("name=Desafio3ApiREST2Context")
        {
        }

        public System.Data.Entity.DbSet<Desafio3ApiREST2.Models.Imagen> Imagens { get; set; }

        public System.Data.Entity.DbSet<Desafio3ApiREST2.Models.Video> Videos { get; set; }
    }
}
