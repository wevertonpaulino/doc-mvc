using DocMvc.Domain.Entities;
using System.Collections.Generic;

namespace DocMvc.Domain.Abstractions.Repositories
{
    public interface IDocumentoRepository : IRepositoryBase<Documento>
    {
        IEnumerable<Documento> GetByTitulo(string titulo);
    }
}
