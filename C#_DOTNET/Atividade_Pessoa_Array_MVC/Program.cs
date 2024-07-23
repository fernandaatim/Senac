﻿namespace Programa {
    public class Program {

        // static List<Pessoa> pessoas = new List<Pessoa>();
        // static List<Pessoa> pessoas = [];

        static void Main() {
            int op = 0;
            do {
                Console.WriteLine("Informe o que vc deseja fazer: ");
                Console.WriteLine(" 1 - para Criar uma Pessoa");
                Console.WriteLine(" 2 - para Listar Pessoas");
                Console.WriteLine(" 3 - para Alterar uma Pessoa");
                Console.WriteLine(" 4 - para Deletar uma Pessoa");
                Console.WriteLine(" 5 - para sair do app");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op) {
                    case 1:
                        PessoaView.CriarPessoa();
                        break;
                    case 2:
                        PessoaView.ListarPessoa();
                        break;
                    case 3:
                        PessoaView.AlterarPessoa();
                        break;
                    case 4:
                        PessoaView.DeletarPessoa();
                        break;
                    case 5:
                        Console.WriteLine("Tchau, saindo, até mais.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while(op != 5);
        }
    }
}
    //     public static void CriarPessoa() {
    //         Console.WriteLine(" ----- Criar ----- ");
    //         // instanciar uma classe (pessoa)
    //         Pessoa pessoa = new Pessoa();

    //         Console.WriteLine("Digite o nome da pessoa: ");
    //         pessoa.Nome = Console.ReadLine();

    //         Console.WriteLine("Digite a idade da pessoa: ");
    //         pessoa.Idade = Convert.ToInt32(Console.ReadLine());

    //         pessoas.Add(pessoa);
    //     }
    //     public static void ListarPessoa() {
    //         Console.WriteLine(" -----  Listar ----- ");
    //         if(pessoas.Count == 0) {
    //             Console.WriteLine("Nenhum pessoa cadastrada no sistema");
    //         } else {
    //             foreach (Pessoa pessoa in pessoas) {
    //                 Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");
    //             }
    //         }
    //     }
    //     public static void AlterarPessoa() {
    //         Console.WriteLine(" ----- Alterar ----- ");
    //         Console.WriteLine("Informe o indice da pessoa para alterar:");
    //         int indice = Convert.ToInt32(Console.ReadLine());
    //         if(indice >= 0 && indice < pessoas.Count){
    //             Pessoa pessoa = pessoas[indice];

    //             Console.WriteLine("Digite o nome da pessoa para alterar:");
    //             pessoa.Nome = Console.ReadLine();

    //             Console.WriteLine("Digite a idade da pessoa para alterar:");
    //             pessoa.Idade = Convert.ToInt32(Console.ReadLine());

    //             pessoas[indice] = pessoa;
    //             Console.WriteLine("Pessoa Alterada com sucesso;");
    //         } else {
    //             Console.WriteLine("Indice inválido");
    //         }
    //     }
    //     public static void DeletarPessoa() {
    //         Console.WriteLine(" ----- Deletar ----- ");
    //         Console.WriteLine("Informe o indice da pessoa para deleta:");
    //         int indice = Convert.ToInt32(Console.ReadLine());
    //         if(indice >= 0 && indice < pessoas.Count){
    //             pessoas.RemoveAt(indice);
    //             Console.WriteLine("Pessoa deletada com sucesso;");
    //         } else {
    //             Console.WriteLine("Indice inválido");
    //         }
    //     }
    // }