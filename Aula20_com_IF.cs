//comandos de interações//
// Sempre que precisar repetir um bloco de comando, uma atividade ou serie de comando use os comandos de repeticao//


using System;
class aula1{
    static void Main(){

/* Utilizando o comando WHILE , tranduzindo ... ENQUANTO
Simplificando, ENQUANTO(i for menor que 10) faça algo, nesse caso escreva Valor do numeroX e X
Se if for igual a 5 escreva Deus é fiel

 */
        
        int [] num=new int[10];

        int i=0;
        while(i<10){
            if (i==5){Console.WriteLine("Deus é fiel");}

           num[0]=0;
            Console.WriteLine("Valor do numero{0} e {1}",i,num[0]);
             i++;


        }

        }

    }


/*
Saída da execussão do programa 

Valor do numero0 e 0
Valor do numero1 e 0
Valor do numero2 e 0
Valor do numero3 e 0
Valor do numero4 e 0
Deus é fiel
Valor do numero5 e 0
Valor do numero6 e 0
Valor do numero7 e 0
Valor do numero8 e 0
Valor do numero9 e 0

*/
