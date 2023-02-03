using AutoGlass.API.Domain.Common.Helpers;
using AutoGlass.API.Domain.Dto;
using AutoGlass.API.Domain.Entities;
using System.Threading.Tasks;

namespace AutoGlass.API.Domain.Repositories.Interfaces
{
    public interface IFornecedorRepository
    {
        public Fornecedor GetById(int id);
        Task<PageList<Fornecedor>> GetAllAsync(PageFilter pageFilter, FornecedorFilterDto fornecedorFilterDto);
    }
}
