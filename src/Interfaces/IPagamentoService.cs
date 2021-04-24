using strategy_pattern_example.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace strategy_pattern_example.Interfaces
{
    public interface IPagamentoService
    {
        FormaPagamentoEnum formaPagamento { get; }
        string EfetuarPagamento(decimal valor);
    }
}
