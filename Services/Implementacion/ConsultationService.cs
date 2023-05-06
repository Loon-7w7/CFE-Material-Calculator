using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Services.Peticiones.ConsultationRequest;
using Services.Repositorios;
using Services.Respuestas.ConsultationResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementacion
{
    /// <summary>
    /// servicio de consultas
    /// </summary>
    public class ConsultationService : ConsultationRepository
    {
        /// <summary>
        /// Contexto de la base de datos
        /// </summary>
        public readonly DataBaseContext _context;
        /// <summary>
        /// Auto Mappper
        /// </summary>
        public readonly IMapper _mapper;
        /// <summary>
        /// Contructor del servicio
        /// </summary>
        /// <param name="context">Contexto de la base de datos</param>
        /// <param name="mapper">Auto Mappper</param>
        public ConsultationService(DataBaseContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>
        /// Metodo para crear Consultas
        /// </summary>
        /// <param name="request">Datos del nueva Consulta</param>
        /// <returns></returns>
        public async Task<bool> CreateConsultation(CreateConsultationRequest request)
        {
            Consultation consultation = new Consultation();
            if(request != null) 
            {
                try 
                {
                    request.Id = Guid.NewGuid();
                    consultation = _mapper.Map<Consultation>(request);
                    await _context.consultations.AddAsync(consultation);
                    await _context.SaveChangesAsync();
                    return true;
                } 
                catch
                {
                    return false;
                }
                
            }
            else { return false; }
        }
        /// <summary>
        /// Metodo para eliminacion de Consultas
        /// </summary>
        /// <param name="request">Id del Consulta</param>
        /// <returns></returns>
        public async Task<bool> DeleteConsultation(DeleteConsultationRequest request)
        {
            try { 
            Consultation? consultation = await _context.consultations.FindAsync(request.Id);
            if(consultation != null) 
            {
                _context.consultations.Remove(consultation);
                await _context.SaveChangesAsync();
                    return true;
            }
                return false;
            }
            catch { return false; }
        }
        /// <summary>
        /// Metodo para obtener los Consultas por su id
        /// </summary>
        /// <param name="request">Id del diospositivo</param>
        /// <returns></returns>
        public async Task<GetConsultationByIdResponse> GetConsultationById(GetConsultationByIdRequest request)
        {
            Consultation? consultation;
            GetConsultationByIdResponse response;
            if (request != null) 
            {
                consultation = await _context.consultations.FirstOrDefaultAsync(x => x.Id == request.Id);
            }
            else 
            {
                consultation = new Consultation();
            }
            response = _mapper.Map<GetConsultationByIdResponse>(consultation);
            return response;
        }
        /// <summary>
        /// Metodo para obtener todos los Consultas
        /// </summary>
        /// <returns></returns>
        public async Task<GetConsultationsResponse> GetConsultations()
        {
            GetConsultationsResponse response = new GetConsultationsResponse();
            response.consultations = await _context.consultations.ToListAsync();
            return response;
        }
        /// <summary>
        /// actualizacion de Consultas
        /// </summary>
        /// <param name="request">Nuevos datos de las Consultas</param>
        /// <returns></returns>
        public async Task<bool> UpdateConsultation(UpdateConsultationRequest request)
        {
            try { 
            Consultation? consultation;
            GetConsultationByIdResponse response;
            if (request != null)
            {
                consultation = await _context.consultations.FirstOrDefaultAsync(x => x.Id == request.Id);
                if (consultation == null) 
                {
                    consultation = _mapper.Map<Consultation>(request);
                    await _context.consultations.AddAsync(consultation);
                }
                else 
                {
                    consultation = _mapper.Map<Consultation>(request);
                    _context.consultations.Update(consultation);
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
