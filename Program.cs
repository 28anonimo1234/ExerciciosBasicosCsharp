using MenuApp.Exercicios;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MENU PRINCIPAL ===");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{i} - Exercício {i}");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": new Exercicio1().Executar(); break;
                case "2": new Exercicio2().Executar(); break;
                case "3": new Exercicio3().Executar(); break;
                case "4": new Exercicio4().Executar(); break;
                case "5": new Exercicio5().Executar(); break;
                case "6": new Exercicio6().Executar(); break;
                case "7": new Exercicio7().Executar(); break;
                case "8": new Exercicio8().Executar(); break;
                case "9": new Exercicio9().Executar(); break;
                case "10": new Exercicio10().Executar(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
