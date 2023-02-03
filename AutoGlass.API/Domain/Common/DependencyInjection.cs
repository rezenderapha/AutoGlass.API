using AutoGlass.API.Domain.Common.Helpers;
using AutoGlass.API.Domain.Common.Helpers.IHelpers;
using AutoGlass.API.Domain.Repositories;
using AutoGlass.API.Domain.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AutoGlass.API.Domain.Common
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IValidate, Validate>();
        }
    }
}
