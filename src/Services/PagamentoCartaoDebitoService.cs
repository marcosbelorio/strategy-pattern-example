using strategy_pattern_example.Enums;
using strategy_pattern_example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace strategy_pattern_example.Services
{
    public class PagamentoCartaoDebitoService : IPagamentoService
    {
        public FormaPagamentoEnum formaPagamento => FormaPagamentoEnum.CartaoDebito;

        public string EfetuarPagamento(decimal valor) => $"Pagamento efetuado com o cartão de débito no valor de R${valor}";
    }
}
