using AutoGlass.API.Domain.Common.Helpers;
using AutoGlass.API.Domain.Context;
using AutoGlass.API.Domain.Entities;
using AutoGlass.API.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlass.API.Domain.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AutoGlassContext _context;
        public ProdutoRepository(AutoGlassContext context)
        {
            _context = context;
        }

        public async Task<PageList<Produto>> GetAllAsync(PageFilter pageFilter, bool? SituacaoProduto)
        {
            IQueryable<Produto> query = _context.Produto;

            if(SituacaoProduto != null)
            query = query.AsNoTracking()
                             .Where(w => w.SituacaoProduto == SituacaoProduto);

            query = query.AsNoTracking()
                         .OrderBy(w => w.Id);

            return await PageList<Produto>.CreateAsync(query, pageFilter.PageNumber, pageFilter.ControlPageSize);
        }

        public Produto GetById(int id)
        {
            IQueryable<Produto> query = _context.Produto;

            query = query.AsNoTracking()
                         .Where(w => w.Id == id);

            return query.FirstOrDefault();
        }
    }
}
