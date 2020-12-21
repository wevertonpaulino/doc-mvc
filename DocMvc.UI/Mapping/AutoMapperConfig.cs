using AutoMapper;

namespace DocMvc.UI.Mapping
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        public static void RegisterMappings()
        {
            var _mapper = new MapperConfiguration(p =>
            {
                p.AddProfile<DomainToViewModelMappingProfile>();
                p.AddProfile<ViewModelToDomainMappingProfile>();
            });

            Mapper = _mapper.CreateMapper();
        }
    }
}