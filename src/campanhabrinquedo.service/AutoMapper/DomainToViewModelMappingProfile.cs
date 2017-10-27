using AutoMapper;
using campanhabrinquedo.Application.ViewModel;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Comunidade, ComunidadeViewModel>();
            CreateMap<Campanha, CampanhaViewModel>();
            CreateMap<Crianca, CriancaViewModel>();
            CreateMap<Comunidade, ComunidadeViewModel>();
            CreateMap<Padrinho, PadrinhoViewModel>();
            CreateMap<Responsavel, ResponsavelViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}