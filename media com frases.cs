{
    Console.WriteLine("*Calcula média e aparece mensagem*");
    Console.Write("Informe a nota 1: ");
    double n1 = double.Parse(Console.ReadLine());
    Console.Write("Informe a nota 2: ");
    double n2 = double.Parse(Console.ReadLine());
    Console.Write("Informe a nota 3: ");
    double n3 = double.Parse(Console.ReadLine());
    Console.Write("Informe a nota 4: ");
    double n4 = double.Parse(Console.ReadLine());
    double media = (n1+n2+n3+n4)/4;
    switch(media)
    {
        case 0 : Console.WriteLine("Reprovado muito abaixo do esperado,sua média é " +media + ".");
        break;
        case 1 : Console.WriteLine("Reprovado abaixo do esperado,sua média é " +media + ".");
        break;
        case 2 : Console.WriteLine("Reprovado estude mais,sua média é " +media + ".");
        break;
        case 3 : Console.WriteLine("Reprovado faltou 1 ponto,sua média é " +media + ".");
        break;
        case 4 : Console.WriteLine("Recuperação precisa de média 8,sua média é " +media + ".");
        break;
        case 5 : Console.WriteLine("Recuperação precisa de média 7,sua média é " +media + ".");
        break;
        case 6 : Console.WriteLine("Recuperação precisa de média 6,sua média é " +media + ".");
        break;
        case 7 : Console.WriteLine("Aprovado tome cuidado na próxima,sua média é " +media + ".");
        break;
        case 8 : Console.WriteLine("Aprovado,sua média é " +media + ".");
        break;
        case 9 : Console.WriteLine("Aprovado parabéns,sua média é " +media + ".");
        break;
        case 10 : Console.WriteLine("Aprovado com louvor,sua média é " +media + ".");
        break;
        default: Console.WriteLine("sua média é " + media);
        break;
    }
}