using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCotacao.Infra.Data.Context
{
    public class FRCotacaoContext : DbContext
    {
        public FRCotacaoContext()
            : base("FRCotacao")
        {
              
        }
    }
}
