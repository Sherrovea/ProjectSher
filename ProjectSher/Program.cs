//CrosSher Crossfit

using System;
using System.Collections.Generic;

string mensagemDeBoasVindas = "\nOlá! Seja bem-vindo ao CrosSher!";


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

void CadastrarAlunos()
    {
    Console.WriteLine();
    }

CadastrarAlunos();
ExibirLogoDaMarca();
ExibirOpcoesDoMenu();

