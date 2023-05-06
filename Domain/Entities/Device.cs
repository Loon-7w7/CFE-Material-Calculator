using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Entidad de dispositavo
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Identificador de dispositivos
        /// </summary>
        public Guid? Id {  get; set; }
        /// <summary>
        /// Nombre del dispositivo
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Clasificacion de tencion del dispositivo
        /// </summary>
        public string Clasificacion { get; set; }
        /// <summary>
        /// Lista de materiales
        /// </summary>
        public List<MaterialDevice> materials { get; set; }
    }
}
