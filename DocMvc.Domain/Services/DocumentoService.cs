using DocMvc.Domain.Abstractions.Repositories;
using DocMvc.Domain.Abstractions.Services;
using DocMvc.Domain.Entities;
using System.Collections.Generic;

namespace DocMvc.Domain.Services
{
    public class DocumentoService : ServiceBase<Documento>, IDocumentoService
    {
        private readonly IDocumentoRepository _documentoRepository;

        public DocumentoService(IDocumentoRepository documentoRepository)
            : base(documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }

        public IEnumerable<Documento> GetByTitulo(string titulo)
        {
            return _documentoRepository.GetByTitulo(titulo);
        }
    }
}
