{
    double res;
    Console.WriteLine("*Calculadora*");
    Console.Write("Digite o primeiro número: ");
    double n1 = double.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    double n2 = double.Parse(Console.ReadLine());
    Console.Write("Qual operação deseja fazer? ");
    string op = Console.ReadLine();
    switch(op)
    {
        case "soma": res = n1 + n2;
        Console.Write("O resultado da " + op + " dos números " + n1 + " e " + n2 + " é ");
        Console.WriteLine(res);
        break;
        case "subtração":  res = n1 - n2;
        Console.Write("O resultado da " + op + " dos números " + n1 + " e " + n2 + " é ");
        Console.WriteLine(res);
        break;
        case "multiplicação": res = n1 * n2;
        Console.Write("O resultado da " + op + " dos números " + n1 + " e " + n2 + " é ");
        Console.WriteLine(res);
        break;
        case "divisão": res = n1 / n2;
        Console.Write("O resultado da " + op + " dos números " + n1 + " e " + n2 + " é ");
        Console.WriteLine(res);
        break;
        default: Console.WriteLine("Essa operação não existe!");
        break;
    
    } 

}