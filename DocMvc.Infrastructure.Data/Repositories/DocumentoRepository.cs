using DocMvc.Domain.Abstractions.Repositories;
using DocMvc.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DocMvc.Infrastructure.Data.Repositories
{
    public class DocumentoRepository : RepositoryBase<Documento>, IDocumentoRepository
    {
        public IEnumerable<Documento> GetByTitulo(string titulo)
        {
            return Db.Documentos.Where(p => p.Titulo.ToUpper().Contains(titulo.ToUpper()));
        }
    }
}
