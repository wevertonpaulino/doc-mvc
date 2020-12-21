using AutoMapper;
using DocMvc.Domain.Entities;
using DocMvc.UI.ViewModels;

namespace DocMvc.UI.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Documento, DocumentoViewModel>();
        }
    }
}