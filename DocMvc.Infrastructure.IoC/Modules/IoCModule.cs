using DocMvc.Application.Abstractions;
using DocMvc.Application.Services;
using DocMvc.Domain.Abstractions.Repositories;
using DocMvc.Domain.Abstractions.Services;
using DocMvc.Domain.Services;
using DocMvc.Infrastructure.Data.Repositories;
using Ninject.Modules;

namespace DocMvc.Infrastructure.IoC.Modules
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IDocumentoAppService>().To<DocumentoAppService>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IDocumentoService>().To<DocumentoService>();

            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IDocumentoRepository>().To<DocumentoRepository>();
        }
    }
}
