using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSher
{
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
        return $"Nome: {Nome}, Idade: {Idade}, Altura {Altura}, Peso {Peso}, CPF {CPF}, Status: {statusPagamento}";
    }
}

}
