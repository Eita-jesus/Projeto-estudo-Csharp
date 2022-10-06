using System;


class aula24
{
    /*
Neste módulo declarei as variaveis, em seguida armazenei o resultado nas variaveis, declarei no medodo somatório e pedi que a método abaixo realizasse a operação.
    */
    static void Main(){
    
    int v1,v2;
    Console.WriteLine("Digite um número:");
    v1=int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um número:");
    v2=int.Parse(Console.ReadLine());

        somatorio(v1, v2);

        Console.WriteLine("Valor final {0}",somatorio(v1, v2));

 }

   static int somatorio(int n1, int n2){
    int res; 
    res=n1+n2;

return res;
    }


}