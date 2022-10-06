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
 }

   static void somatorio(int n1, int n2){
    int res; 
    res=n1+n2;

    Console.WriteLine("A soma de {0} e {1} é igual: {2}",n1,n2,res);

    }


}