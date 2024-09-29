int status = 1; // Exemplo de status: 1 - Aprovado, 2 - Pendente, 3 - Rejeitado

Console.WriteLine("::: TIPOS DE CONDICIONAIS :::");
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

// if, else if, else (Exemplo básico de condicionais)
Console.WriteLine("\nif, else if, else");
if (status == 1)
{
    Console.WriteLine("Pedido Aprovado.");
}
else if (status == 2)
{
    Console.WriteLine("Pedido Pendente.");
}
else
{
    Console.WriteLine("Pedido Rejeitado.");
}

Console.WriteLine("-----------------------------");

// switch case (Forma clássica de switch)
Console.WriteLine("switch case");
switch (status)
{
    case 1:
        Console.WriteLine("Pedido Aprovado.");
        break;
    case 2:
        Console.WriteLine("Pedido Pendente.");
        break;
    case 3:
        Console.WriteLine("Pedido Rejeitado.");
        break;
    default:
        Console.WriteLine("Status Desconhecido.");
        break;
}

Console.WriteLine("-----------------------------");

// switch expression (Nas versões mais recentes do C#, podemos utilizar o switch expression que é escrito de forma mais objetivo.)
Console.WriteLine("switch expression");
string resultado = status switch
{
    1 => "Pedido Aprovado.",
    2 => "Pedido Pendente.",
    3 => "Pedido Rejeitado.",
    _ => "Status Desconhecido."
};
Console.WriteLine(resultado);

Console.WriteLine("-----------------------------");

// operador ternário
Console.WriteLine("operador ternário");

string resultado2 = (status == 1) ? "Pedido Aprovado." : (status == 2) ? "Pedido Pendente." : "Pedido Rejeitado.";
Console.WriteLine(resultado2);

Console.WriteLine("-----------------------------");

// when com switch (No switch, podemos usar o modificador when para adicionar condições extras)
Console.WriteLine("when com switch");

bool ehUrgente = true;
string resultado3 = status switch
{
    1 when ehUrgente => "Pedido Aprovado com Urgência.",
    1 => "Pedido Aprovado.",
    2 => "Pedido Pendente.",
    3 => "Pedido Rejeitado.",
    _ => "Status Desconhecido."
};
Console.WriteLine(resultado3);

Console.WriteLine("-----------------------------\n");

Console.WriteLine("::: OPERADORES LÓGICOS :::");
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

// Operador && (AND lógico)
Console.WriteLine("\n&&");

bool aprovado = (status == 1);
bool pago = true;

if (aprovado && pago)
{
    Console.WriteLine("O pedido está aprovado e pago.");
}
else
{
    Console.WriteLine("O pedido não está completo.");
}

Console.WriteLine("-----------------------------");

// Operador || (OR lógico)
Console.WriteLine("OR");

bool aprovado2 = true;
bool pago2 = false;

if (aprovado2 || pago2)
{
    Console.WriteLine("O pedido está parcialmente completo.");
}
else
{
    Console.WriteLine("O pedido não está aprovado nem pago.");
}

Console.WriteLine("-----------------------------");

// Operador ! (NOT lógico)
Console.WriteLine("! NOT");

bool estaChovendo = false;

if (!estaChovendo) // !false = true | !true = false => se não estiver chovendo eu irei sair
{
    Console.WriteLine("Irei sair, pois não está chovendo.");
}
else
{
    Console.WriteLine("Não irei sair, pois está chovendo.");
}

Console.WriteLine("-----------------------------");

// null-coalescing (Operadores úteis quando trabalhamos com valores nulos ou verificamos objetos.)
Console.WriteLine("null-coalescing");

int? statusPodeSerNull = null;

// Se status for null, atribui o valor 0.
int resultado4 = statusPodeSerNull ?? 0;

if (resultado4 == 0)
    Console.WriteLine("O status do pedido é nulo.");

Console.WriteLine("-----------------------------");
