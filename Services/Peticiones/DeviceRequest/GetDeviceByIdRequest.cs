using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Peticiones.DeviceRequest
{
    /// <summary>
    /// Peticion para obtener dispositivos por id
    /// </summary>
    public class GetDeviceByIdRequest
    {
        /// <summary>
        /// Id del dipositivo
        /// </summary>
        public Guid Id { get; set; }
    }
}
