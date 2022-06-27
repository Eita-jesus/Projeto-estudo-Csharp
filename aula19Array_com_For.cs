//comandos de interações//
// Sempre que precisar repetir um bloco de comando, uma atividade ou serie de comando use os comandos de repeticao//


using System;
class aula1{
    static void Main(){

/* O looping FOR é dividido em três partes//
//Expressão 1, 2 e 3. 
//Expressao 1 indica o incio da repetição num=0
//Expressao 2 indica a quantidade de repetições, Eu Matheus Js gosto de dizer que a expresão dois é o limitador, limitarei quando //chegar em 10.
//Expressão 3, é o sequenciador, qual será a sequência ? num++ ou num = num+1 ou então num = num+2 ou até mesmo num +=1 */
        
        int [] num=new int[10];

        for(int i=0;i<num.Length ;i++){
        num[0]=i;
           
        }

        for(int i=0;i<num.Length ;i++){
                Console.WriteLine("O valor de num na pos{0}: {1}",i,num[0]);

                /*Lembrando que num[0]=i mas acima i=0 */

        }

    }
}

/*
        int [] num=new int[10];
        num[2]=3;

    
        for(int i=0;i<10;i++){
        Console.WriteLine("Está safo ? {0}",num);
        num[0]=i;
        num[1]=1;
           
        }

        for(int i=0;i<10;i++){
                Console.WriteLine("O valor de num na pos{0}: {1}",i,num[0]);   */