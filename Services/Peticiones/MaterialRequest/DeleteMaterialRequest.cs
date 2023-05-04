using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Peticiones.MaterialRequest
{
    /// <summary>
    /// peticion para eliminar un material
    /// </summary>
    public class DeleteMaterialRequest
    {
        /// <summary>
        /// Id del material
        /// </summary>
        public Guid Id { get; set; }
    }
}
