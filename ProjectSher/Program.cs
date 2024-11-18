//CrosSher Crossfit

using ProjectSher;
using System;
using System.Collections.Generic;



//Essa função exibe o logo e uma mensagem de boas vindas no console
void ExibirLogoDaMarca()
{
    Console.WriteLine(@"
░█▀▀█ █▀▀█ █▀▀█ █▀▀ ░█▀▀▀█ █──█ █▀▀ █▀▀█ 
░█─── █▄▄▀ █──█ ▀▀█ ─▀▀▀▄▄ █▀▀█ █▀▀ █▄▄▀ 
░█▄▄█ ▀─▀▀ ▀▀▀▀ ▀▀▀ ░█▄▄▄█ ▀──▀ ▀▀▀ ▀─▀▀");

    Console.WriteLine(mensagemDeBoasVindas);
    
}
//Essa função exibe a lista de opções 
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para cadastrar um novo aluno");
    Console.WriteLine("Digite 2 para abrir a lista de alunos cadastros");
    Console.WriteLine("Digite 3 para visualizar a lista de alunos pagantes e não pagantes");
    Console.WriteLine("Digite 4 para consultar um aluno");
    Console.WriteLine("Digite Esc para sair");
}
//Função para cadastrar alunos
void CadastrarAlunos()
    {
    Console.WriteLine("/nCadastro de Aluno");

    Console.WriteLine("Nome do Aluno: ");
    string nome = Console.ReadLine()!;

    Console.Write("Idade do Aluno: ");
    int idade = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Altura do Aluno: ");
    decimal altura = decimal.Parse(Console.ReadLine()!);

    Console.WriteLine("Peso do Aluno: ");
    decimal peso = decimal.Parse(Console.ReadLine()!);

    Console.WriteLine("CPF do Aluno: ");
    string cpf = Console.ReadLine()!;    

    Console.WriteLine("O Aluno é pagante? (s/n): ");
    bool estaPagando = (Console.ReadLine()!.ToLower() == "s");
    
    Aluno novoAluno =  new Aluno(nome, idade, altura, peso, cpf, estaPagando);
    listaDeAlunos.Add(novoAluno);

    Console.WriteLine("/nAluno {nome} cadastrado com sucesso!/n");
    }

void ListarAlunos()
{
    Console.WriteLine("/nLista de alunos cadastrados: ");

    if (listaDeAlunos.Count == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado.");
    }
    else
    {
        foreach (var aluno in listaDeAlunos)
        {
            Console.WriteLine(aluno);
        }

    }
    ExibirLogoDaMarca();
    while (true)
    {
        ConsoleKeyInfo tecla = Console.ReadKey();

        if(tecla.Key == ConsoleKey.Escape)
        {
            break;
        }
        else if(tecla.KeyChar == '1')
        {
            CadastrarAlunos();
        }
        else if (tecla.KeyChar == '2')
    {
            ListarAlunos();
        }
    }

    ListarAlunos();
CadastrarAlunos();
ExibirLogoDaMarca();
ExibirOpcoesDoMenu();
}

