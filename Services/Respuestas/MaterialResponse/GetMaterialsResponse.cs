using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Respuestas.MaterialResponse
{
    /// <summary>
    /// Respuesta para una lista de materiales
    /// </summary>
    public class GetMaterialsResponse
    {
        /// <summary>
        /// Lista de materiales
        /// </summary>
        public List<Material> Materials { get; set; }
    }
}
