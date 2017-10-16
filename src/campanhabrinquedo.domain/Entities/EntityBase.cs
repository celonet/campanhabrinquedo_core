using System;

namespace campanhabrinquedo.domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
        public DateTime DataCadastro { get; protected set; }

        public void IncluiDataCadastro()
        {
            DataCadastro = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
