using Microsoft.AspNetCore.Mvc;
using Services.Peticiones.DeviceRequest;
using Services.Repositorios;
using Services.Respuestas.DeviceResponse;
using Ubiety.Dns.Core;

namespace CFE_Material_Calculator.Controllers.DeviceControllers
{
    /// <summary>
    /// Controlador de apis de dispositivos
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        /// <summary>
        /// importar los servicios
        /// </summary>
        public readonly DeviceRepository DeviceRepository;
        /// <summary>
        /// Constructor del controlador
        /// </summary>
        /// <param name="deviceRepository">servicios de dispositivos</param>
        public DeviceController(DeviceRepository deviceRepository) 
        {
            DeviceRepository = deviceRepository;
        }
        /// <summary>
        /// obtine lista de dispositivos
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> GetDivices()
        {
            GetDevicesResponse response = await DeviceRepository.GetDivices();
            return Ok(response);
        }
        /// <summary>
        /// Obtiene un dispositivo por id
        /// </summary>
        /// <param name="request">Id del dispositivo</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            GetDeviceByIdRequest request = new GetDeviceByIdRequest() { Id = id };
            GetDeviceByIdResponse response = await DeviceRepository.GetDeviceById(request);
            return Ok(response);
        }
        /// <summary>
        /// Crea un dispositivo
        /// </summary>
        /// <param name="request">datos de d</param>
        [HttpPost("Create")]
        public async Task<IActionResult> PostDeive([FromBody] CreateDeviceRequest request)
        {
            bool success = await DeviceRepository.CreateDevice(request);
            if (success)
            {
                return Ok("Se Guardo con exito");
            }
            {
                return BadRequest("No se pudo guardar");
            }
        }
        /// <summary>
        /// actualiza un dispositivo
        /// </summary>
        /// <param name="request">datos del dispositivo actualizados</param>
        [HttpPut("Update/")]
        public async Task<IActionResult> PutDevice( [FromBody] UpdateDeviceRequest request)
        {
            bool success = await DeviceRepository.UpdateDevice(request);
            if (success) 
            {
                return Ok("Se actualizo Correctamente");
            }
            else { return BadRequest("No se pudo actulizar"); }
        }
        /// <summary>
        /// emimina dispositivos
        /// </summary>
        /// <param name="id">Id del dispositivo</param>
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteDevice(Guid id)
        {
            DeleteDeviceRequest request = new DeleteDeviceRequest() { DeviceId = id };
            bool success = await DeviceRepository.DeleteDevice(request);
            if(success) 
            {
                return Ok("Se elimino correctamente");
            }
            else {return BadRequest("No se pudo Eliminar");
            }
        }
    }
}
