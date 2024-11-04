//CrosSher Crossfit

using System;
using System.Collections.Generic;

string mensagemDeBoasVindas = "\nOlá! Seja bem-vindo ao CrosSher!";

public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public decimal Altura { get; set; }
    public decimal Peso { get; set; }
    public string CPF { get; set; }
    public bool EstaPagando { get; set; }

    public Aluno(string nome, int idade, decimal altura, decimal peso, string cpf, bool estaPagando)
    {
        Nome = nome;
        Idade = idade;  
        Altura = altura;
        Peso = peso;
        CPF = cpf;
        EstaPagando = estaPagando;
    }
    public override string ToString()
    {
        string statusPagamento = EstaPagando ? "Pagante" : "Não Pagante";
        return $"Nome: {Nome}, Idade: {Idade}, Status: {statusPagamento}";
    }
}

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

