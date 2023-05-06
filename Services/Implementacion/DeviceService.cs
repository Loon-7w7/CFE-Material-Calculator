using AutoMapper;
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
        public readonly DataBaseContext _context;
        /// <summary>
        /// AutoMapper
        /// </summary>
        private readonly IMapper _mapper;
        /// <summary>
        /// contructor de dispositivos servicios
        /// </summary>
        /// <param name="mapper">Auto Mappper</param>
        /// <param name="context">Contexto de la base de datos</param>
        public DeviceService(IMapper mapper, DataBaseContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        /// <summary>
        /// Metodo para crear dispositivos
        /// </summary>
        /// <param name="request">Datos del nuevo dispositivo</param>
        /// <returns></returns>
        public async Task<bool> CreateDevice(CreateDeviceRequest request)
        {
            try { 
                if (request != null)
                {
                    request.Id = Guid.NewGuid();
                    Device device = _mapper.Map<Device>(request);
                    await _context.devices.AddAsync(request);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else { return false; }
            } catch { return false; }
        }
        /// <summary>
        /// Metodo para eliminacion de Dispositivos
        /// </summary>
        /// <param name="request">Id del despositivo</param>
        /// <returns></returns>
        public async Task<bool> DeleteDevice(DeleteDeviceRequest request)
        {
            try { 
            Device? device = new Device();
            if (request.DeviceId != Guid.Empty) 
            {
                device = await _context.devices.FirstOrDefaultAsync(x => x.Id == request.DeviceId);

                if (device != null)
                {
                    _context.devices.Remove(device);
                }
                    await _context.SaveChangesAsync();
                    return true;
            }
                else { return false; }
            }
            catch { return false; }
        }
        /// <summary>
        /// Metodo para obtener los dispositivos por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        public async Task<GetDeviceByIdResponse> GetDeviceById(GetDeviceByIdRequest request)
        {
            Device? device = new Device();
            GetDeviceByIdResponse response = new GetDeviceByIdResponse();
            if (request.Id != Guid.Empty)
            {
                device = await _context.devices.FirstOrDefaultAsync(x => x.Id == request.Id);
                if (device != new Device()) 
                {
                    response = _mapper.Map<GetDeviceByIdResponse>(device);
                }
            }
            return response;
        }
        /// <summary>
        /// Metodo para obtener todos los dispositivos
        /// </summary>
        /// <returns></returns>
        public async Task<GetDevicesResponse> GetDivices()
        {
            GetDevicesResponse response = new GetDevicesResponse();
            response.devices = await _context.devices.ToListAsync();
            return response;
        }
        /// <summary>
        /// actualizacion de dispositivos
        /// </summary>
        /// <param name="request">Nuevos datos de los dispositivos</param>
        /// <returns></returns>
        public async Task<bool> UpdateDevice(UpdateDeviceRequest request)
        {
            try { 
            if (request!= null) 
            {
                Device? device = await _context.devices.FindAsync(request.Id);
                if(device != null) 
                {
                    device = _mapper.Map<Device>(request);
                    _context.devices.Update(device);
                }
                else 
                {
                    device = _mapper.Map<Device>(request);
                    await _context.devices.AddAsync(device);
                }
                await _context.SaveChangesAsync();
                    return true;
            }
                else { return false; }
            }
            catch { return false; }
        }
    }
}
