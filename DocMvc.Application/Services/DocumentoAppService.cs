using DocMvc.Application.Abstractions;
using DocMvc.Domain.Abstractions.Services;
using DocMvc.Domain.Entities;
using System.Collections.Generic;

namespace DocMvc.Application.Services
{
    public class DocumentoAppService : AppServiceBase<Documento>, IDocumentoAppService
    {
        private readonly IDocumentoService _documentoService;

        public DocumentoAppService(IDocumentoService documentoService)
            : base(documentoService)
        {
            _documentoService = documentoService;
        }

        public IEnumerable<Documento> GetByTitulo(string titulo)
        {
            return _documentoService.GetByTitulo(titulo);
        }
    }
}
