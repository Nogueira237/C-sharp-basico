{
    int resultado = 0;
    int numero = 0;
    do
    { 
        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());
        resultado = resultado + numero;
        Console.WriteLine("O resultado é: {0}.",resultado);

    }while(numero != 0);

}