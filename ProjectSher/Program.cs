//CrosSher Crossfit
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
    Console.WriteLine("\nCadastrar aluno");
    Console.WriteLine("Lista de alunos cadastrados: ");
    Console.WriteLine("Lista de alunos pagantes e não pagantes: ");
    Console.WriteLine("Consultar aluno");
    Console.WriteLine("Digite Esc para sair");
}

void CadastrarAlunos()
    {
    Console.WriteLine();
    }

CadastrarAlunos();
ExibirLogoDaMarca();
ExibirOpcoesDoMenu();

