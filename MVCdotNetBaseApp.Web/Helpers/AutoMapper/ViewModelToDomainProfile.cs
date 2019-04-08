using AutoMapper;
using MVCdotNetBaseApp.Application.ViewModels;
using MVCdotNetBaseApp.Domain.Entities.Formulario;


namespace MVCdotNetBaseApp.Web.Helpers.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        private readonly IMapper _mapper;

        public ViewModelToDomainProfile(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ViewModelToDomainProfile()
        {
            CreateMap<Formulario, FormularioViewModel>().ReverseMap();
        }
    }
}
