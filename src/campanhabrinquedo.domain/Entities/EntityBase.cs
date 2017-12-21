using System;
using System.Collections.Generic;

namespace campanhabrinquedo.domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
        public DateTime DataCadastro { get; protected set; }
        public IList<string> Errors { get; protected set; }

        public void IncluiDataCadastro()
        {
            DataCadastro = DateTime.Now;
            Errors = new List<string>();
        }

        public abstract bool IsValid();

        public abstract IList<string> GetErrors();
    }
}
