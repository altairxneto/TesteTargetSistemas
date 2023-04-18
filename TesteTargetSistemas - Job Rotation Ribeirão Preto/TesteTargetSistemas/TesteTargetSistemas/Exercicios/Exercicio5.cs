namespace TesteTargetSistemas.Exercicios {
    internal class Exercicio5 {
        public static void Ex5() {
            Console.WriteLine("Digite a string que deseja inverter: ");
            string texto = Console.ReadLine();

            for (int contador = (texto.Length-1); contador >= 0; contador--) {
                Console.Write(texto[contador]);
            }
        }
    }
}
