using Domain.Entities;
using Microsoft.EntityFrameworkCore;
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
        public async Task CreateDevice(CreateDeviceRequest request)
        {
            if (request.NewDevice != null)
            {
                await context.devices.AddAsync(request.NewDevice);
                await context.SaveChangesAsync();
            }

        }
        /// <summary>
        /// Metodo para eliminacion de Dispositivos
        /// </summary>
        /// <param name="request">Id del despositivo</param>
        /// <returns></returns>
        public async Task DeleteDevice(DeleteDeviceRequest request)
        {
            Device device = new Device();
            if (request.DeviceId != Guid.Empty) 
            {
                device = await context.devices.FirstOrDefaultAsync(x => x.Id == request.DeviceId);

                if (device != null)
                {
                    context.devices.Remove(device);
                    await context.SaveChangesAsync();
                }
            }
            
            
        }
        /// <summary>
        /// Metodo para obtener los dispositivos por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        public async Task<GetDeviceByIdResponse> GetDeviceById(GetDeviceByIdRequest request)
        {
            Device device = new Device();
            GetDeviceByIdResponse response = new GetDeviceByIdResponse();
            if (request.Id != Guid.Empty)
            {
                device = await context.devices.FirstOrDefaultAsync(x => x.Id == request.Id);

                return response;
            }
            return response;
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
