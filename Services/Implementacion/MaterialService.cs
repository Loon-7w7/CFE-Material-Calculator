using Persistence;
using Services.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementacion
{
    public class MaterialService : MaterialRepository
    {
        public readonly DataBaseContext context = new DataBaseContext();
    }
}
