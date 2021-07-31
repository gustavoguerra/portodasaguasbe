using AutoMapper;
using Deposito.Application.ViewModel;
using Deposito.Domain.Models;
using Deposito.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Deposito.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        protected readonly IMapper _mapper;
        protected readonly IProdutoServices _services;

        public ProdutoController(IProdutoServices services, IMapper mapper)
        {
            _mapper = mapper;
            _services = services;
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Insert(ProdutoViewModel obj)
        {
            var result = _mapper.Map<ProdutoDomain>(obj);

            _services.Insert(result);

            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(ProdutoViewModel obj)
        {
            var result = _mapper.Map<ProdutoDomain>(obj);

            _services.Update(result);

            return Ok();
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var result = _services.GetAll();

            return Ok(result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _services.GetById(id);

            var listagem = _mapper.Map<ProdutoViewModel>(result);

            return Ok(listagem);
        }

    }
}
