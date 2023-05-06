Console.Write(@"   --- ° FLUXOGRAMA DA ENGENHARIA ° ---

O objeto está se movendo? (S/N) ");
string movendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

bool mv = movendo == "S";
bool mvn = movendo == "N";
bool mvv = mv || mvn;

if (!mvv)
{
    Console.WriteLine("Informe somente S ou N");
    return;
}

Console.Write("Deveria? (S/N) ");

string deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

bool dv = deveria == "S";
bool dvn = deveria == "N";
bool dvv = dv || dvn;

if (!dvv)
{
    Console.WriteLine("Informe somente S ou N");
    return;
}
string mensagem;

if (!mv)
{
    if (!dv)
    { mensagem = "Tão ta bão!"; }
    else
    { mensagem = "TÃO TA RUIM!, Use o WD-40."; }
}
else
{
    if (dv)
    { mensagem = "Tão ta bão!"; }
    else
    { mensagem = "TÃO TA RUIM!, Use Silver Tape."; }
}

Console.WriteLine();
Console.WriteLine(mensagem);

// Jenni e nicolas fizeram juntos