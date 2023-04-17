namespace TesteTargetSistemas.Exercicios {
    internal class Exercicio1 {
        public static int Ex1() {
            int indice = 13, soma = 0, k = 0;

            while (k < indice) {
                k += 1;
                soma += k;
            }

            return soma;
        }
    }
}
