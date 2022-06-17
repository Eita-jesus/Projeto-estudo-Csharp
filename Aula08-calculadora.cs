using System; 

class Aula08{
    
    static void Main(){
        int n1,n2,soma;

        Console.WriteLine ("Digite um número:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Digite um número");
        n2 = Convert.ToInt32(Console.ReadLine ());
        soma=(n1*n2);

        Console.WriteLine("A multiplicação de {0} e {1} é igual {2}",n1,n2,soma);


    }
}
