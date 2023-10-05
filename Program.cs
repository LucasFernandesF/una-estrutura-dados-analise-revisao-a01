string nome, vacinaEmDia = string.Empty, sintomas = string.Empty, contatoGripal = string.Empty, viagem = string.Empty, orientacaoFinal = string.Empty;
int idade, contador = 0, percentualInfeccao = 0;
bool tentativasErradas = false;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Respondas as questões a seguir com respostas de SIM ou NÃO.");
do
{
    Console.WriteLine("Seu cartão de vacina está em dia? ");
    vacinaEmDia = Console.ReadLine().ToUpper();

    if (vacinaEmDia == "SIM" || vacinaEmDia == "NÃO" || vacinaEmDia == "NAO") { break; }
    else
    {
        contador++;
        Console.WriteLine("\nResposta errada! Digite SIM ou NÃO");
    }
    if (contador == 3)
    {
        tentativasErradas = true;
        Console.WriteLine("Não foi possível realizar o diagnóstico. Gentileza procurar ajuda médica caso apareça algum sintoma.");
        break;
    }
} while (true);

contador = 0;

if (tentativasErradas == false)
{
    do
    {
        Console.WriteLine("Teve algum dos sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe)");
        sintomas = Console.ReadLine().ToUpper();
        if (sintomas == "SIM" || sintomas == "NÃO" || sintomas == "NAO") { break; }
        else
        {
            contador++;
            Console.WriteLine("\nResposta errada! Digite SIM ou NÃO");
        }
        if (contador == 3)
        {
            tentativasErradas = true;
            Console.WriteLine("Não foi possível realizar o diagnóstico. Gentileza procurar ajuda médica caso apareça algum sintoma.");
            break;
        }
    } while (true);

}

contador = 0;

if (tentativasErradas == false)
{
    do
    {
        Console.WriteLine("Teve contato com pessoas com sintomas gripais nos últimos dias?");
        viagem = Console.ReadLine().ToUpper();
        if (viagem == "SIM" || viagem == "NÃO" || viagem == "NAO") { break; }
        else
        {
            contador++;
            Console.WriteLine("\nResposta errada! Digite SIM ou NÃO");
        }
        if (contador == 3)
        {
            tentativasErradas = true;
            Console.WriteLine("Não foi possível realizar o diagnóstico. Gentileza procurar ajuda médica caso apareça algum sintoma.");
            break;
        }
    } while (true);

}

contador = 0;

if (tentativasErradas == false)
{
    do
    {
        Console.WriteLine("Está retornando de viagem realizada no exterior?");
        contatoGripal = Console.ReadLine().ToUpper();
        if (contatoGripal == "SIM" || contatoGripal == "NÃO" || contatoGripal == "NAO") { break; }
        else
        {
            contador++;
            Console.WriteLine("\nResposta errada! Digite SIM ou NÃO");
        }
        if (contador == 3)
        {
            tentativasErradas = true;
            Console.WriteLine("Não foi possível realizar o diagnóstico. Gentileza procurar ajuda médica caso apareça algum sintoma.");
            break;
        }
    } while (true);

}

if (vacinaEmDia != "SIM") { percentualInfeccao += 10; }

if (sintomas == "SIM") { percentualInfeccao += 30; }

if (contatoGripal == "SIM") { percentualInfeccao += 30; }

if (viagem == "SIM") { percentualInfeccao += 30; }

if (percentualInfeccao <= 30)
{
    orientacaoFinal = "Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica.";
}
else if (percentualInfeccao <= 60)
{
    orientacaoFinal = "Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado.";
}
else if (percentualInfeccao >= 90)
{
    orientacaoFinal = "Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado";
}
else if (viagem == "SIM")
{
    orientacaoFinal = "Você ficará sob observação por 05 dias.";
}
else
{
    orientacaoFinal = "Paciente com alto risco de estar infectado. Gentileza aguardar em lockdown por 05 dias para ser acompanhado.";
}


if (tentativasErradas == false)
{
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("idade: " + idade);
    Console.WriteLine("o cartão de vacina está em dia: " + vacinaEmDia);
    Console.WriteLine("Teve sintomas recentemente: " + sintomas);
    Console.WriteLine("Teve contato com pessoas infectadas: " + contatoGripal);
    Console.WriteLine("Está retornando de viagem: " + viagem);
    Console.WriteLine("Probabilidade de infecção " + percentualInfeccao);
    Console.WriteLine(orientacaoFinal);
}

Console.ReadLine();