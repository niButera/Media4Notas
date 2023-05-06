﻿decimal B1, B2, B3, B4, media;

Console.Write(@"   --- ° NOTAS BIMESTRE ° ---
Digite sua nota do 1º Bimestre: "); 
B1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("2º Bimestre: "); 
B2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("3º Bimestre: "); 
B3 = Convert.ToDecimal(Console.ReadLine());

Console.Write("4º Bimestre: "); 
B4 = Convert.ToDecimal(Console.ReadLine());

media = (B1 + B2 + B3 + B4) / 4;

Console.WriteLine($"Média: {media}");

if (media >= 5)
    Console.WriteLine("Aprovado");
else
    Console.WriteLine("Reprovado");