using AutoMapper;
using campanhabrinquedo.Application.ViewModel;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //Campanha
            CreateMap<CampanhaViewModel, Campanha>()
                .ConstructUsing(c => new Campanha(c.Ano, c.Descricao));
            CreateMap<CampanhaViewModel, Campanha>()
                .ConstructUsing(c => new Campanha(c.Id, c.Ano, c.Descricao, c.QtdeCriancas));
            //Comunidade
            CreateMap<ComunidadeViewModel, Comunidade>()
                .ConstructUsing(c => new Comunidade(c.Nome, c.Bairro));
            CreateMap<ComunidadeViewModel, Comunidade>()
                .ConstructUsing(c => new Comunidade(c.Id, c.Nome, c.Bairro));
            //Crianca
            CreateMap<CriancaViewModel, Crianca>()
                .ConstructUsing(c => new Crianca(c.Nome, c.Idade, c.Sexo, Mapper.Map<Comunidade>(c.Comunidade), Mapper.Map<Responsavel>(c.Responsavel)));
            CreateMap<CriancaViewModel, Crianca>()
                .ConstructUsing(c => new Crianca(c.Id, c.Nome, c.Idade, c.Sexo, Mapper.Map<Comunidade>(c.Comunidade), Mapper.Map<Responsavel>(c.Responsavel), c.Impresso, c.Especial));
            //Padrinho
            CreateMap<PadrinhoViewModel, Padrinho>()
                .ConstructUsing(c => new Padrinho(c.Nome, Mapper.Map<Comunidade>(c.Comunidade), c.Telefone));
            CreateMap<PadrinhoViewModel, Padrinho>()
                .ConstructUsing(c => new Padrinho(c.Id, c.Nome, Mapper.Map<Comunidade>(c.Comunidade), c.Telefone, c.Celular));
            //Responsavel
            CreateMap<ResponsavelViewModel, Responsavel>()
                .ConstructUsing(c => new Responsavel(c.Nome, c.RG));
            CreateMap<ResponsavelViewModel, Responsavel>()
                .ConstructUsing(c => new Responsavel(c.Id, c.Nome, c.RG));
            //Usuario
            CreateMap<UsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(u.Nome, u.Email, u.Senha));
            CreateMap<UsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(u.Id, u.Nome, u.Email, u.Senha));
        }
    }
}