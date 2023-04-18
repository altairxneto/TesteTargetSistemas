namespace TesteTargetSistemas.Exercicios {
    internal class Exercicio2 {
        public static void Ex2() {
            Console.WriteLine("Digite a quantidade de números que deseja obter do fibonacci: ");
            int quantidadeNumerosFibonacci = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[quantidadeNumerosFibonacci];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int inicio = 2; inicio <= quantidadeNumerosFibonacci; inicio++) {
                fibonacci[inicio] = fibonacci[inicio - 1] + fibonacci[inicio - 2];
            }

            Console.WriteLine("Digite o número que deseja saber se tem na série de Fibonacci de até 50 dígitos: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine(fibonacci.Contains(numero) ? "Este número pertence à série de Fibonacci" : "Este número não pertence a série");
        }
    }
}
