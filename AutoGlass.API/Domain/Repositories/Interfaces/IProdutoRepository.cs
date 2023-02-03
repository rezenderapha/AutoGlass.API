using AutoGlass.API.Domain.Common.Helpers;
using AutoGlass.API.Domain.Entities;
using System.Threading.Tasks;

namespace AutoGlass.API.Domain.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        public Produto GetById(int id);
        Task<PageList<Produto>> GetAllAsync(PageFilter pageFilter, bool? SituacaoProduto);
    } 
}
