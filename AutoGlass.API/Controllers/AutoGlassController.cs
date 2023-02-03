using AutoGlass.API.Domain.Common.Helpers;
using AutoGlass.API.Domain.Common.Helpers.IHelpers;
using AutoGlass.API.Domain.Dto;
using AutoGlass.API.Domain.Entities;
using AutoGlass.API.Domain.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoGlass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoGlassController : ControllerBase
    {
        private readonly IRepository _repo;
        private readonly IProdutoRepository _produto;
        private readonly IFornecedorRepository _fornecedor;
        private readonly IMapper _mapper;
        private readonly IValidate _validate;
        public AutoGlassController(IRepository repo, IProdutoRepository produto, IMapper mapper, IValidate validate, IFornecedorRepository fornecedor)
        {
            _repo = repo;
            _produto = produto;
            _mapper = mapper;
            _validate = validate;
            _fornecedor = fornecedor;
        }

        [HttpGet("product/{id}")]
        public IActionResult ProductGetById(int id)
        {
            var response = _produto.GetById(id);
            if (response == null) return BadRequest("Produto não encontrado");

            var responseDto = _mapper.Map<ProdutoDto>(response);
            return Ok(responseDto);
        }

        [HttpGet("product/getall")]
        public async Task<IActionResult> GetAllAsync([FromQuery] bool? situacaoproduto, [FromQuery] PageFilter pageFilter)
        {
            var response = await _produto.GetAllAsync(pageFilter, situacaoproduto);
            if (response.Count == 0) return BadRequest("Produto não encontrado");

            var responseDto = _mapper.Map<List<ProdutoDto>>(response);
            Response.AddPagination(response.CurrentPage, response.PageSize, response.TotalCount,response.TotalPages);

            return Ok(responseDto);
        }

        [HttpPost("product/add")]
        public IActionResult ProductAdd(ProdutoAddDto produtoAddDto)
        {
            if (!_validate.CheckDate(produtoAddDto))
                return BadRequest("Datas Invalidas");

            var response = _mapper.Map<Produto>(produtoAddDto);

            _repo.Add(response);
            if (_repo.SaveChanges())
            {
                return Ok("Produto Cadastrado");
            }
            return BadRequest("Produto não cadastrado");
        }

        [HttpPut("product/update")]
        public IActionResult ProductUpdate(int id, ProdutoAddDto produtoAddDto)
        {
            if (!_validate.CheckDate(produtoAddDto))
                return BadRequest("Datas Invalidas");

            var response = _produto.GetById(id);
            if (response == null) return BadRequest("Produto não encontrado");

            _mapper.Map(produtoAddDto, response);

            _repo.Update(response);  
            if (_repo.SaveChanges())
            {
                return Ok("Produto Atualizado");
            }
            return BadRequest("Produto não Atualizado");
        }

        [HttpDelete("product/delete/{id}")]
        public IActionResult ProductDelete(int id)
        {
            var response = _produto.GetById(id);
            if (response == null) return BadRequest("Produto não encontrado");
            response.SituacaoProduto = false;
            
            _repo.Update(response);
            if (_repo.SaveChanges())
            {
                return Ok("Produto Deletado");
            }
            return BadRequest("Produto não deletado");
        }

        [HttpGet("provider/{id}")]
        public IActionResult ProviderGetById(int id)
        {
            var response = _fornecedor.GetById(id);
            if (response == null) return BadRequest("Fornecedor não encontrado");

            var responseDto = _mapper.Map<FornecedorDto>(response);
            return Ok(responseDto);
        }

        [HttpGet("provider/getall")]
        public async Task<IActionResult> GetAllAsync([FromQuery] PageFilter pageFilter, [FromQuery] FornecedorFilterDto fornecedorFilterDto)
        {
            var response = await _fornecedor.GetAllAsync(pageFilter, fornecedorFilterDto);
            if (response.Count == 0) return BadRequest("Fornecedor não encontrado");

            var responseDto = _mapper.Map<List<FornecedorDto>>(response);
            Response.AddPagination(response.CurrentPage, response.PageSize, response.TotalCount, response.TotalPages);

            return Ok(responseDto);
        }

        [HttpPost("provider/add")]
        public IActionResult ProviderAdd(FornecedorAddDto fornecedorAddDto)
        {
            var response = _mapper.Map<Fornecedor>(fornecedorAddDto);

            _repo.Add(response);
            if (_repo.SaveChanges())
            {
                return Ok("Fornecedor Cadastrado");
            }
            return BadRequest("Fornecedor não cadastrado");
        }

        [HttpPut("provider/update")]
        public IActionResult providerUpdate(int id, FornecedorAddDto fornecedorAddDto)
        {
            var response = _fornecedor.GetById(id);
            if (response == null) return BadRequest("Fornecedor não encontrado");

            _mapper.Map(fornecedorAddDto, response);

            _repo.Update(response);
            if (_repo.SaveChanges())
            {
                return Ok("Fornecedor Atualizado");
            }
            return BadRequest("Fornecedor não Atualizado");
        }

        [HttpDelete("provider/delete/{id}")]
        public IActionResult ProviderDelete(int id)
        {
            var response = _fornecedor.GetById(id);
            if (response == null) return BadRequest("Fornecedor não encontrado");
            response.SituacaoFornecedor = false;

            _repo.Update(response);
            if (_repo.SaveChanges())
            {
                return Ok("Fornecedor Deletado");
            }
            return BadRequest("Fornecedor não deletado");
        }
    }
}
