using DocMvc.Domain.Entities;
using System.Collections.Generic;

namespace DocMvc.Domain.Abstractions.Services
{
    public interface IDocumentoService : IServiceBase<Documento>
    {
        IEnumerable<Documento> GetByTitulo(string titulo);
    }
}
