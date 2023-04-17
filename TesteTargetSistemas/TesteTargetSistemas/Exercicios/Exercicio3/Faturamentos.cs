
namespace TesteTargetSistemas.Exercicios.Exercicio3 {
    public class Faturamentos {
        private FaturamentoDiario[] _faturamentosDiarios;

        public Faturamentos(FaturamentoDiario[] faturamentosDiario) {
            _faturamentosDiarios = faturamentosDiario;
        }

        public double ObterMenorFaturamento() {
            return _faturamentosDiarios.MinBy(f => f.Valor).Valor;
        }

        public double ObterMaiorFaturamento() {
            return _faturamentosDiarios.MaxBy(f => f.Valor).Valor;
        }

        public int[] ObterDiasMaiorQueMediaMensal() {
            double mediaMensal = _faturamentosDiarios.Average(f => f.Valor);

            return _faturamentosDiarios.Where(f => f.Valor > mediaMensal).Select(f => f.Dia).ToArray();
        }
    }
}
