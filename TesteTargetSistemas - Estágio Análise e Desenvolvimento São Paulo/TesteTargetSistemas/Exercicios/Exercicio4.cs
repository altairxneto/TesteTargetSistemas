namespace TesteTargetSistemas.Exercicios {
    internal static class Exercicio4 {
        public static void Ex4() {
            Dictionary<string, double> faturamentoEstados = new();

            faturamentoEstados["SP"] = 67836.43;
            faturamentoEstados["RJ"] = 36678.66;
            faturamentoEstados["MG"] = 29229.88;
            faturamentoEstados["ES"] = 27165.48;
            faturamentoEstados["OUTROS"] = 19849.53;

            double faturamentoTotal = faturamentoEstados.Sum(f=> f.Value);

            foreach (var faturamentos in faturamentoEstados) {
                double percentual = faturamentos.Value * 100 / faturamentoTotal;

                Console.WriteLine("O estado " + faturamentos.Key + " faturou " + percentual.ToString("F2") + " porcento em comporação ao faturamento total");
            }
        }
    }
}
