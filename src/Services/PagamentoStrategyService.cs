using strategy_pattern_example.Enums;
using strategy_pattern_example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace strategy_pattern_example.Services
{
    public class PagamentoStrategyService : IPagamentoStrategyService
    {
        private readonly IEnumerable<IPagamentoService> _services;

        public PagamentoStrategyService(IEnumerable<IPagamentoService> services)
        {
            _services = services;
        }

        public string EfetuarPagamento(FormaPagamentoEnum formaPagamento, decimal valor)
        {
            return _services.FirstOrDefault(x => x.formaPagamento == formaPagamento)?
                .EfetuarPagamento(valor) ?? throw new ArgumentNullException(nameof(formaPagamento));
        }
    }
}
