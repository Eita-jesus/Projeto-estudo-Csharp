//comandos de interações//
// Sempre que precisar repetir um bloco de comando, uma atividade ou serie de comando use os comandos de repeticao//


using System;
class aula1{
    static void Main(){

/* Utilizando o comando WHILE , tranduzindo ... ENQUANTO
Simplificando, ENQUANTO(i for menor que 10) faça algo nesse caso escreva 

*/
        

// Observação muito importante no While: Além disso, lembre-se de inserir no bloco de código a lógica necessária para que a condição se torne falsa em alguma execução do loop. Por isso, usei no comando abaixo o operador diferente != e não igual == 
//Caso tenha mais dúvida olhe o while.png no Git.


        int [] num=new int[10];
        String senha, senha1;

        do{
            Console.WriteLine("Digite uma senha:");
            senha = Console.ReadLine();
            senha1 ="123456";


        }while(senha != senha1);{
            Console.WriteLine("Senha autenticada com sucesso!");


        }



        }

    }



