using AutoMapper;
using campanhabrinquedo.Application.ViewModel;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ComunidadeViewModel, Comunidade>()
                .ConstructUsing(c => new Comunidade(c.Nome, c.Bairro));
            CreateMap<ComunidadeViewModel, Comunidade>()
                .ConstructUsing(c => new Comunidade(c.Id, c.Nome, c.Bairro));
        }
    }
}