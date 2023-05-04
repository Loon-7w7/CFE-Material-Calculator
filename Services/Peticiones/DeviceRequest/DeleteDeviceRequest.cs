using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Peticiones.DeviceRequest
{
    /// <summary>
    /// Peticion para eliminar dispositivos
    /// </summary>
    public class DeleteDeviceRequest
    {
        /// <summary>
        /// Id del dispositivo
        /// </summary>
        public Guid DeviceId { get; set; }
    }
}
