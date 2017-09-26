namespace campanhabrinquedo.service.Services
{
    using System;
    using System.Collections.Generic;
    using campanhabrinquedo.domain.Entities;
    using campanhabrinquedo.domain.Services;
    using campanhabrinquedo.domain.Repositories;

    public class CriancaService : ICriancaService
    {
        private ICriancaRepository _repository;

        public CriancaService(ICriancaRepository repositorio)
        {
            _repository = repositorio;
        }
    }
}