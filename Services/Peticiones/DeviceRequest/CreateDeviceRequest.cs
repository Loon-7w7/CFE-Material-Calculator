using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Peticiones.DeviceRequest
{
    /// <summary>
    /// Peticion para crear dispositivos
    /// </summary>
    public class CreateDeviceRequest
    {
        /// <summary>
        /// Nuevos datos del dispositivo
        /// </summary>
        public Device NewDevice { get; set; }
    }
}
