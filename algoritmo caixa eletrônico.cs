{
    int n1;
    Console.WriteLine("Você tem R$1000 disponíveis,quanto deseja sacar?");
    n1 = int.Parse(Console.ReadLine());
    if(n1 < 1000){
        int nv = 1000 - n1;
        Console.Write("Você sacou ");
        Console.WriteLine(n1);
        Console.Write("Seu novo saldo disponível é ");
        Console.Write(nv);
        Console.WriteLine(" reais");
    }else{
        Console.Write("Saldo insuficiente, ");
        Console.Write("faltam ");
        Console.Write(n1 - 1000);
        Console.WriteLine(" reais");

    }
}





