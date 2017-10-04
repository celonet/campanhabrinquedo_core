using System;

namespace campanhabrinquedo.domain.Entities
{
    public abstract class EntitieBase
    {
        public Guid Id { get; protected set; }
        public DateTime DataCadastro { get; protected set; }

        public void IncluiDataCadastro()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}
