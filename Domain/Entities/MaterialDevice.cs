using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// entidad de materiales con respecto a los dispositivos
    /// </summary>
    public class MaterialDevice : Material
    {
        /// <summary>
        /// Total de material
        /// </summary>
        public float Total { get; set; }
    }
}
