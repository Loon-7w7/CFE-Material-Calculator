using Microsoft.AspNetCore.Mvc;
using Services.Peticiones.ConsultationRequest;
using Services.Peticiones.MaterialRequest;
using Services.Repositorios;
using Services.Respuestas.ConsultationResponse;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CFE_Material_Calculator.Controllers.ConsultationControllers
{
    /// <summary>
    /// Controlador de apis para consultas
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : ControllerBase
    {
        /// <summary>
        /// importar servicios de consultas
        /// </summary>
        public readonly ConsultationRepository ConsultationRepository;
        /// <summary>
        /// constructor del controlador
        /// </summary>
        /// <param name="consultationRepository">servicios de consultas</param>
        public ConsultationController(ConsultationRepository consultationRepository)
        {
            ConsultationRepository = consultationRepository;
        }

        /// <summary>
        /// obtine lista de consultas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetConsultas()
        {
            GetConsultationsResponse respose = await ConsultationRepository.GetConsultations();
            return Ok(respose);
        }

        /// <summary>
        /// Obtiene una consulta por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsultasById(Guid id)
        {
            GetConsultationByIdRequest request = new GetConsultationByIdRequest() { Id = id };
            GetConsultationByIdResponse respose = await ConsultationRepository.GetConsultationById(request);
            return Ok(respose);
        }

        /// <summary>
        /// Crea una consulta 
        /// </summary>
        /// <param name="request">Datos de la consulta</param>
        /// <returns></returns>
        [HttpPost("Create")]
        public async Task<IActionResult> PostCreate([FromBody] CreateConsultationRequest request)
        {
            bool success = await ConsultationRepository.CreateConsultation(request);
            if (success)
            {
                return Ok("Se Creo Correctamente");
            }
            else
            {
                return BadRequest("No se pudo crear");
            }
        }

        /// <summary>
        /// Actuliza la consulta
        /// </summary>
        /// <param name="request">nuevos datos de la consulta</param>
        /// <returns></returns>
        [HttpPut("Update")]
        public async Task<IActionResult> PutUpdate([FromBody] UpdateConsultationRequest request)
        {
            bool success = await ConsultationRepository.UpdateConsultation(request);
            if (success)
            {
                return Ok("Se Actualizo Correctamente");
            }
            else
            {
                return BadRequest("No se pudo actualizar");
            }
        }

        /// <summary>
        /// Elimina una consulta
        /// </summary>
        /// <param name="id">id de la consulta</param>
        /// <returns></returns>
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            DeleteConsultationRequest request = new DeleteConsultationRequest() { Id = id };
            bool success = await ConsultationRepository.DeleteConsultation(request);
            if (success)
            {
                return Ok("Se elimino Correctamente");
            }
            else
            {
                return BadRequest("No se pudo eliminar");
            }
        }
    }
}
