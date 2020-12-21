using DocMvc.Domain.Entities;
using System.Collections.Generic;

namespace DocMvc.Application.Abstractions
{
    public interface IDocumentoAppService : IAppServiceBase<Documento>
    {
        IEnumerable<Documento> GetByTitulo(string titulo);
    }
}
