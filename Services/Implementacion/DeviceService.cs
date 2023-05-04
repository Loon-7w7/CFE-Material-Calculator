using Persistence;
using Services.Peticiones.DeviceRequest;
using Services.Repositorios;
using Services.Respuestas.DeviceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementacion
{
    /// <summary>
    /// Servicio de dispositivos
    /// </summary>
    public class DeviceService : DeviceRepository
    {
        /// <summary>
        /// Contexto de la base de datos
        /// </summary>
        public readonly DataBaseContext context = new DataBaseContext();

        /// <summary>
        /// Metodo para crear dispositivos
        /// </summary>
        /// <param name="request">Datos del nuevo dispositivo</param>
        /// <returns></returns>
        public Task CreateDevice(CreateDeviceRequest request)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo para eliminacion de Dispositivos
        /// </summary>
        /// <param name="request">Id del despositivo</param>
        /// <returns></returns>
        public Task DeleteDevice(DeleteDeviceRequest request)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo para obtener los dispositivos por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        public Task<GetDeviceByIdResponse> GetDeviceById(GetDeviceByIdRequest request)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo para obtener todos los dispositivos
        /// </summary>
        /// <returns></returns>
        public Task<GetDevicesResponse> GetDivices()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// actualizacion de dispositivos
        /// </summary>
        /// <param name="request">Nuevos datos de los dispositivos</param>
        /// <returns></returns>
        public Task UpdateDevice(UpdateDeviceRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
