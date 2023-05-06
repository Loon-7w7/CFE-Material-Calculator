using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// entidad de Materiales
    /// </summary>
    public class Material
    {
        /// <summary>
        /// Identificador de material
        /// </summary>
        public Guid? Id { get; set; }
        /// <summary>
        /// Nombre del material
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Unidad de material
        /// </summary>
        public string Unit { get; set; }
    }
}
