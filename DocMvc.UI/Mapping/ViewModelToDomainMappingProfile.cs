using AutoMapper;
using DocMvc.Domain.Entities;
using DocMvc.UI.ViewModels;

namespace DocMvc.UI.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<DocumentoViewModel, Documento>();
        }
    }
}