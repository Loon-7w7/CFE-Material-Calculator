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
        public async Task CreateDevice(CreateDeviceRequest request)
        {
            if (request.NewDevice != null)
            {
                await _context.devices.AddAsync(request.NewDevice);
                await _context.SaveChangesAsync();
            }

        }
        /// <summary>
        /// Metodo para eliminacion de Dispositivos
        /// </summary>
        /// <param name="request">Id del despositivo</param>
        /// <returns></returns>
        public async Task DeleteDevice(DeleteDeviceRequest request)
        {
            Device? device = new Device();
            if (request.DeviceId != Guid.Empty) 
            {
                device = await _context.devices.FirstOrDefaultAsync(x => x.Id == request.DeviceId);

                if (device != null)
                {
                    _context.devices.Remove(device);
                    await _context.SaveChangesAsync();
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
        public async Task UpdateDevice(UpdateDeviceRequest request)
        {
            if (request!= null) 
            {
                Device? device = await _context.devices.FindAsync(request.Id);
                if(device != null) 
                {
                    device = request;
                    _context.devices.Update(device);
                    await _context.SaveChangesAsync();
                }
                else 
                {
                    device = _mapper.Map<UpdateDeviceRequest>(request);
                    await _context.devices.AddAsync(device);
                    await _context.SaveChangesAsync();
                }
            }
            
        }
    }
}
