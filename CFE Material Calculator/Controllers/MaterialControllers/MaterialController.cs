using Microsoft.AspNetCore.Mvc;
using Services.Peticiones.ConsultationRequest;
using Services.Peticiones.MaterialRequest;
using Services.Repositorios;
using Services.Respuestas.MaterialResponse;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CFE_Material_Calculator.Controllers.MaterialControllers
{
    /// <summary>
    /// controlador de apis para materiales
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        /// <summary>
        /// Importar servicios
        /// </summary>
        public readonly MaterialRepository MaterialRepository;
        /// <summary>
        /// Constructor del controlador
        /// </summary>
        /// <param name="materialRepository">servicios de matriales</param>
        public MaterialController(MaterialRepository materialRepository)
        {
            MaterialRepository = materialRepository;
        }

        /// <summary>
        /// Obtiene una lista de materiales
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetMaterials()
        {
            GetMaterialsResponse response = await MaterialRepository.GetMaterials();
            return Ok(response);
        }

        /// <summary>
        /// Obtiene un matrial por su id
        /// </summary>
        /// <param name="id">id del material</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMatrialById(Guid id)
        {
            GetMaterialByIdRequest request = new GetMaterialByIdRequest() { Id = id };
            GetMaterialByIdResponse response = await MaterialRepository.GetMaterialById(request);
            return Ok(response);
        }

        /// <summary>
        /// Crea un material
        /// </summary>
        /// <param name="request">Datos del material</param>
        /// <returns></returns>
        [HttpPost("Create/")]
        public async Task<IActionResult> PostCreate([FromBody] CreateMaterialRequest request)
        {
            bool success = await MaterialRepository.CreateMaterial(request);
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
        /// Actualiza un materia
        /// </summary>
        /// <param name="request">datos nuevos de material</param>
        /// <returns></returns>
        [HttpPut("Update/")]
        public async Task<IActionResult> PutUpdate([FromBody] UpdateMaterialRequest request)
        {
            bool success = await MaterialRepository.UpdateMaterial(request);
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
        /// elimina un materaial
        /// </summary>
        /// <param name="id">id del mtarial</param>
        /// <returns></returns>
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            DeleteMaterialRequest request = new DeleteMaterialRequest() { Id = id };
            bool success = await MaterialRepository.DeleteMaterial(request);
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
