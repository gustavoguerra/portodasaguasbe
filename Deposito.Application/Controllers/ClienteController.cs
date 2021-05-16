using AutoMapper;
using Deposito.Application.ViewModel;
using Deposito.Domain.Models;
using Deposito.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Deposito.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClienteController : ControllerBase
    {
        protected readonly IMapper _mapper;
        protected readonly IClienteServices _services;
     
        public ClienteController (IClienteServices services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

     
        [HttpPost]
        [Route("create")]
        public IActionResult Insert(ClienteViewModel obj)
        {
            var result = _mapper.Map<ClienteDomain>(obj);

            _services.Insert(result);

            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(ClienteViewModel obj)
        {
            var result = _mapper.Map<ClienteDomain>(obj);

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

            var listagem = _mapper.Map<ClienteViewModel>(result);

            return Ok(listagem);
        }
    }
}
