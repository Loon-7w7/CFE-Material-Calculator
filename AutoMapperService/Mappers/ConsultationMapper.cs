using AutoMapper;
using Domain.Entities;
using Services.Peticiones.ConsultationRequest;
using Services.Respuestas.ConsultationResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperService.Mappers
{
    /// <summary>
    /// Mapper de consultas
    /// </summary>
    public class ConsultationMapper : Profile
    {
        public ConsultationMapper() 
        {
            /// <summary>
            /// mapea de CreateConsultationRequest a Consultation
            /// </summary>
            CreateMap<CreateConsultationRequest, Consultation>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(entidad => entidad.Number, opt => opt.MapFrom(dto => dto.Number))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(entidad => entidad.Date, opt => opt.MapFrom(dto => dto.Date))
                .ForMember(entidad => entidad.Description, opt => opt.MapFrom(dto => dto.Description))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsHeavy))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsSemiIsolated))
                .ForMember(entidad => entidad.Devices, opt => opt.MapFrom(dto => dto.Devices));
            /// <summary>
            /// mapea de Consultation a CreateConsultationRequest 
            /// </summary>
            CreateMap< Consultation, CreateConsultationRequest>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(entidad => entidad.Number, opt => opt.MapFrom(dto => dto.Number))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(entidad => entidad.Date, opt => opt.MapFrom(dto => dto.Date))
                .ForMember(entidad => entidad.Description, opt => opt.MapFrom(dto => dto.Description))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsHeavy))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsSemiIsolated))
                .ForMember(entidad => entidad.Devices, opt => opt.MapFrom(dto => dto.Devices));
            /// <summary>
            /// mapea de GetConsultationByIdResponse a Consultation
            /// </summary>
            CreateMap<GetConsultationByIdResponse, Consultation>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(entidad => entidad.Number, opt => opt.MapFrom(dto => dto.Number))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(entidad => entidad.Date, opt => opt.MapFrom(dto => dto.Date))
                .ForMember(entidad => entidad.Description, opt => opt.MapFrom(dto => dto.Description))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsHeavy))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsSemiIsolated))
                .ForMember(entidad => entidad.Devices, opt => opt.MapFrom(dto => dto.Devices));
            /// <summary>
            /// mapea de Consultation GetConsultationByIdResponse
            /// </summary>
            CreateMap< Consultation, GetConsultationByIdResponse>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(entidad => entidad.Number, opt => opt.MapFrom(dto => dto.Number))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(entidad => entidad.Date, opt => opt.MapFrom(dto => dto.Date))
                .ForMember(entidad => entidad.Description, opt => opt.MapFrom(dto => dto.Description))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsHeavy))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsSemiIsolated))
                .ForMember(entidad => entidad.Devices, opt => opt.MapFrom(dto => dto.Devices));
            /// <summary>
            /// mapea de UpdateConsultationRequest a Consultation
            /// </summary>
            CreateMap<UpdateConsultationRequest, Consultation>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(entidad => entidad.Number, opt => opt.MapFrom(dto => dto.Number))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(entidad => entidad.Date, opt => opt.MapFrom(dto => dto.Date))
                .ForMember(entidad => entidad.Description, opt => opt.MapFrom(dto => dto.Description))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsHeavy))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsSemiIsolated))
                .ForMember(entidad => entidad.Devices, opt => opt.MapFrom(dto => dto.Devices));
            /// <summary>
            /// mapea de Consultation a UpdateConsultationRequest
            /// </summary>
            CreateMap<Consultation, UpdateConsultationRequest>()
                .ForMember(entidad => entidad.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(entidad => entidad.Number, opt => opt.MapFrom(dto => dto.Number))
                .ForMember(entidad => entidad.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(entidad => entidad.Date, opt => opt.MapFrom(dto => dto.Date))
                .ForMember(entidad => entidad.Description, opt => opt.MapFrom(dto => dto.Description))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsHeavy))
                .ForMember(entidad => entidad.IsHeavy, opt => opt.MapFrom(dto => dto.IsSemiIsolated))
                .ForMember(entidad => entidad.Devices, opt => opt.MapFrom(dto => dto.Devices));
        }
    }
}
