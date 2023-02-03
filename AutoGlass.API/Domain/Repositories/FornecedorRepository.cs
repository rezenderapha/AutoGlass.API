using AutoGlass.API.Domain.Common.Helpers;
using AutoGlass.API.Domain.Context;
using AutoGlass.API.Domain.Dto;
using AutoGlass.API.Domain.Entities;
using AutoGlass.API.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlass.API.Domain.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly AutoGlassContext _context;
        public FornecedorRepository(AutoGlassContext context)
        {
            _context = context;
        }

        public async Task<PageList<Fornecedor>> GetAllAsync(PageFilter pageFilter, FornecedorFilterDto fornecedorFilterDto)
        {
            IQueryable<Fornecedor> query = _context.Fornecedor;
            
            if (fornecedorFilterDto.Cnpj != null)
                query = query.AsNoTracking()
                             .Where(w => w.Cnpj == fornecedorFilterDto.Cnpj);
            if (fornecedorFilterDto.Descricao != null)
                query = query.AsNoTracking()
                             .Where(w => w.Descricao == fornecedorFilterDto.Descricao);
            if (fornecedorFilterDto.SituacaoFornecedor != null)
                query = query.AsNoTracking()
                             .Where(w => w.SituacaoFornecedor == fornecedorFilterDto.SituacaoFornecedor);
            if (fornecedorFilterDto.Id != null)
                query = query.AsNoTracking()
                             .Where(w => w.Id == fornecedorFilterDto.Id);

            query = query.AsNoTracking()
                         .Include(w => w.Produto)
                         .OrderBy(o => o.Id);                         

            return await PageList<Fornecedor>.CreateAsync(query, pageFilter.PageNumber, pageFilter.ControlPageSize);
        }

        public Fornecedor GetById(int id)
        {
            IQueryable<Fornecedor> query = _context.Fornecedor;

            query = query.AsNoTracking()
                         .Where(w => w.Id == id);                       

            return query.FirstOrDefault();
        }
    }
}
