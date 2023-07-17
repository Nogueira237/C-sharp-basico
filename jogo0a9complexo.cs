{
    int n2;
    Console.Write("Jogador 1, infome um número: ");
    int n1 = int.Parse(Console.ReadLine());
    while(n1<0 | n1>9)
    {
        Console.Write("Escreva um número entre 0 e 9: ");
        n1 = int.Parse(Console.ReadLine());
    }
    Console.Clear();
    do
    {
        Console.Write("Jogador 2, tente descobrir o número: ");
         n2 = int.Parse(Console.ReadLine());
         while(n2<0 | n2>9)
        {
            Console.Write("Escreva um número entre 0 e 9: ");
            n2 = int.Parse(Console.ReadLine());
        }
        if(n1 == n2)
        {
            Console.WriteLine("Parabéns você acertou! o número era {0}",n1);
        }else
        {
            Console.WriteLine("Errado,tente novamente");
        }
         


    }while(n1 != n2);
}