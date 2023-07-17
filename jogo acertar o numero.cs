{
    Console.WriteLine("The rules are: player one chooses a random number and the other player try to discover");
    Console.Write("Player one,please insert your number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.Write("Now, player two tries to discover the number,insert a number: ");
    int n2 = int.Parse(Console.ReadLine());
    while(n1 != n2)
    {
        Console.Write("Wrong number,try again: ");
        n2 = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Congratulations! you got it right!");
    
}