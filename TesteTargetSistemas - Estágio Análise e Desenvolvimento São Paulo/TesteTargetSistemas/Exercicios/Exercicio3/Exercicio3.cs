using System.Reflection.Metadata;
using System.Text.Json;

namespace TesteTargetSistemas.Exercicios.Exercicio3 {
    public class Exercicio3 {
        private static string LerArquivoJson() {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Exercicios\\Exercicio3", "dados.json");
            return File.ReadAllText(path);
        }

        private static FaturamentoDiario[] DesserializarJson(string json) {

            var options = new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<FaturamentoDiario[]>(json, options);
        }

        public static void ProcessarFaturamentos() {
            string json = LerArquivoJson();
            FaturamentoDiario[] faturamentosDia = DesserializarJson(json);

            FaturamentoDiario[] semFaturamento = faturamentosDia.Where(f => f.Valor == 0).ToArray();

            Faturamentos faturamentos = new(faturamentosDia.Except(semFaturamento).ToArray());

            double menorFaturamento = faturamentos.ObterMenorFaturamento();
            double maiorFaturamento = faturamentos.ObterMaiorFaturamento();
            int[] diasMaiorQueMediaMensal = faturamentos.ObterDiasMaiorQueMediaMensal();

            Console.WriteLine($"O menor faturamento foi R${menorFaturamento.ToString("F2")}");
            Console.WriteLine($"O maior faturamento foi R${maiorFaturamento.ToString("F2")}");

            Console.Write("Os dias que o faturamento foram maior que a media mensal foram: ");

            foreach (int dia in diasMaiorQueMediaMensal) {
                Console.Write($"{dia} ");
            }
        }
    }
}
