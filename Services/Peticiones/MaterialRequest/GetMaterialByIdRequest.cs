using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Peticiones.MaterialRequest
{
    /// <summary>
    /// Peticion para obtener material por ID
    /// </summary>
    public class GetMaterialByIdRequest
    {
        /// <summary>
        /// Id del material
        /// </summary>
        public Guid Id { get; set; }
    }
}
