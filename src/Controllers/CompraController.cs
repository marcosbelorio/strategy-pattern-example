using strategy_pattern_example.Enums;
using strategy_pattern_example.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy_pattern_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompraController : ControllerBase
    {
        private readonly IPagamentoStrategyService _service;

        public CompraController(IPagamentoStrategyService service)
        {
            _service = service;
        }

        [HttpPost("{FormaPagamento}")]
        public IActionResult Post([FromRoute] FormaPagamentoEnum formaPagamento, [FromBody] decimal valor)
        {
            return Ok(_service.EfetuarPagamento(formaPagamento, valor));
        }
    }
}
