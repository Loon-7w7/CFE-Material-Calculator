using Domain.Entities;
using Services.Peticiones.DeviceRequest;
using Services.Respuestas.DeviceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositorios
{
    /// <summary>
    /// Interfaz de dispositivos
    /// </summary>
    public interface DeviceRepository
    {
        /// <summary>
        /// Metodo para obtener los dispositivos por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        Task<GetDeviceByIdResponse> GetDeviceById (GetDeviceByIdRequest request);
        /// <summary>
        /// Metodo para obtener todos los dispositivos
        /// </summary>
        /// <returns></returns>
        Task<GetDevicesResponse> GetDivices();
        /// <summary>
        /// Metodo para crear dispositivos
        /// </summary>
        /// <param name="request">Datos del nuevo dispositivo</param>
        /// <returns></returns>
        Task<bool> CreateDevice(CreateDeviceRequest request);
        /// <summary>
        /// Metodo para eliminacion de Dispositivos
        /// </summary>
        /// <param name="request">Id del despositivo</param>
        /// <returns></returns>
        Task<bool> DeleteDevice (DeleteDeviceRequest request);
        /// <summary>
        /// actualizacion de dispositivos
        /// </summary>
        /// <param name="request">Nuevos datos de los dispositivos</param>
        /// <returns></returns>
        Task<bool> UpdateDevice(UpdateDeviceRequest request);
    }
}
