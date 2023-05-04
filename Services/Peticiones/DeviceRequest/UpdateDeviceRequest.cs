using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Peticiones.DeviceRequest
{
    /// <summary>
    /// Peticion para actualizar dispositivos
    /// </summary>
    public class UpdateDeviceRequest
    {
        /// <summary>
        /// Nuevoas datos de los dispositivos
        /// </summary>
        public Device NewDevice { get; set; }
    }
}
