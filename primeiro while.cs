{
    int resultado = 0;
    Console.Write("Informe um número: ");
    int n1 = int.Parse(Console.ReadLine());
    while(n1 != 0)
    {
        resultado = resultado + n1;
        Console.WriteLine("O resultado é " + resultado);
        Console.Write("Digite outro número: ");
        n1 = int.Parse(Console.ReadLine());

    }
    Console.WriteLine("Resultado final é " + resultado);
    
}