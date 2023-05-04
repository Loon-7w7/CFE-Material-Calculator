using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Respuestas.DeviceResponse
{
    /// <summary>
    /// Respues de lista de dispositivos
    /// </summary>
    public class GetDevicesResponse
    {
        /// <summary>
        /// Lista de dispositivos
        /// </summary>
        public List<Device> devices { get; set; }
    }
}
