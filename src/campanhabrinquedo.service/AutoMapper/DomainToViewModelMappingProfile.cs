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
            CreateMap<Campanha, CampanhaViewModel>()
                .ConstructUsing(campanha => new CampanhaViewModel()
                {
                    Id = campanha.Id,
                    Ano = campanha.Ano,
                    Descricao = campanha.Descricao,
                    QtdeComunidade = campanha.Responsaveis.Count,
                    QtdeCriancas = campanha.Criancas.Count,
                    QtdePadrinho = campanha.Padrinhos.Count,
                    QtdeResponsavel = campanha.Responsaveis.Count,
                    Errors = campanha.GetErrors()
                });
            CreateMap<Crianca, CriancaViewModel>();
            CreateMap<Comunidade, ComunidadeViewModel>();
            CreateMap<Padrinho, PadrinhoViewModel>();
            CreateMap<Responsavel, ResponsavelViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}