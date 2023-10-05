# Estrutura de Dados e Análise de Algoritmos

## Revisão - Exercício 01

<p align="center">
  <a href="#">
    <img src="logo\virus.png" width="300" alt="Virus">
  </a>
</p>

Exercício para revisão do conteúdo de Estrutura de Dados e Análise de Algoritmos.<br>
Leia atentamente o texto e contexto a seguir, e em seguida desenvolva a solução proposta:

### Trecho do Texto:

"Nas últimas semanas, o influenza H5N1, vírus causador da gripe aviária, voltou a figurar nas manchetes de todo o mundo.
Das cidades litorâneas do Daguestão, na Rússia, à costa do Peru, passando por fazendas de visons na Espanha
e granjas nos Estados Unidos, foram vários os episódios registrados de milhões de animais que morreram (ou foram sacrificados)
após terem contato com esse agente infeccioso.<br>

Agências de saúde e pesquisadores do mundo inteiro aumentaram o nível de alerta sobre esse tipo de influenza
e o potencial que ele possui de causar a próxima pandemia.
"Com a capacidade de ser transmitido de uma pessoa para outra, o H5N1 pode ser um dos problemas mais graves
que a humanidade já enfrentou", diz o virologista Edison Luiz Durigon, professor titular
do Instituto de Ciências Biomédicas da Universidade de São Paulo (ICB-USP)."

Fonte: https://www.bbc.com/portuguese/brasil-65214720 <br>
Acessado em 04 de Outubro de 2023

 ### Contexto:

"Paiva Junior é um dos pesquisadores virologistas que acompanham a saga das pandemias.
Recentemente ele foi contratado para ajudar na identificação de possíveis expansões virais no Brasil vindas do exterior.<br>
Ele teve a idéia de fazer um questionário de perguntas para todos os turistas e pessoas que estão viajando
e que estão retornando ou conhecendo o Brasil.
Mas para conseguir agilizar o processo de identificação de pessoas infectadas, precisará de ajuda."

Você apoiará na rápida identificação de pessoas sintomáticas e será responsável por criar uma solução em C#<br>
que faça as seguintes perguntas para as pessoas:

- Informe o seu nome: 
- Informe a sua idade: 

Perguntas que o sistema fará com respostas "SIM" ou "NAO":

- Seu cartão de vacina está em dia?
- Teve algum dos sintomas recentemente? 
  (dor de cabeça, febre, náusea, dor articular, gripe)
- Teve contato com pessoas com sintomas gripais nos últimos dias?
- Está retornando de viagem realizada no exterior?


O seu programa deverá calcular a porcentagem de risco que a pessoa oferece.<br>
O cálculo da probabilidade de infecção que deverá ser realizado é <br>
a soma da porcentagem de todas as perguntas com respostas "SIM" e "NAO", sendo:

- Cartão Vacinal em Dia - "NAO" : ***+10%***
- Teve Sintomas Recentes - "SIM": ***+30%***
- Teve contato com pessoa infectada - "SIM": ***+30%***
- Retornando de viagem - "SIM": ***+30%***

O programa deverá imprimir no final uma orientação para apoiar na triagem de todas essas pessoas.
A lógica para orientação final, será baseada na porcentagem de uma pessoa estar infectada, sendo:

- Porcentagem menor ou igual a 30%: <br>*"Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica."*
- Porcentagem menor ou igual a 60%: <br>*"Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado."*
- Porcentagem menor ou igual a 89%: <br>*"Paciente com alto risco de estar infectado. Gentileza aguardar em lockdown por 05 dias para ser acompanhado."*
- Porcentagem igual ou superior a 90%: <br>*"Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado"*
- Indiferente da porcentagem, caso a pessoa esteja retornando de viagem, imediatamente imprimir: <br>*"Você ficará sob observação por 05 dias."*

Caso a pessoa informe uma resposta errada para cada uma das 04 perguntas de "SIM" e NAO",<br>
o programa fará novamente a mesma pergunta por mais duas tentativas.<br>
Caso erre por três vezes, o programa será encerrado com a mensagem:

```text
"Não foi possível realizar o diagnóstico.
Gentileza procurar ajuda médica caso apareça algum sintoma."
```

Após coletar os dados com sucesso e realizar os cálculos, o programa deverá imprimir:

```text
Nome
Idade
Se o cartão de vacina está em dia
Se teve sintomas recentemente
se teve contato com pessoas infectadas
se a pessoa está retornando de viagem
A probabilidade dessa pessoa estar infectada
A orientação final do atendimento
```

### Orientações Finais

O programa deverá ser feito na linguagem ***C#***.<br>
Lembre-se de testar a solução antes de entregá-la.<br>
Você deverá criar um ***"Fork"*** deste repositório, e após isso, versionar o programa no seu repositório.<br>
Você deverá enviar o link (url) do seu repositório na atividade da lista proposta em aula.<br>
Bons estudos!

### Solução do Problema
```
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
```
