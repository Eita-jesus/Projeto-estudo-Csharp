//Nesta aula iremos mostrar um exemplo de Matriz//
//Como na matemática, na programacão podemos criar matrizes para índices. Veja a seguir//
//MATRIZ
//Abaixo temos uma matriz de 3 LINHA e 5 COLUNAS
// 10,20,30,40,50
// 11,22,33,44,55
// 12,13,14,15,16


using System;

class aula18{
    static void Main(){
        int [,] n=new int[3,5]; //3,5 lembrando 3 LINHA e 5 COLUNAS//
        //OBS: lembre-se que indices começam em zero//
        n[0,0]=10; n[0,1]=20; n[0,2]=30; n[0,3]=40; n[0,4]=50;
        n[1,0]=10; n[1,1]=20; n[1,2]=30; n[1,3]=40; n[1,4]=50;
        n[2,0]=10; n[2,1]=20; n[2,2]=30; n[2,3]=40; n[2,4]=50;

        Console.WriteLine("Valor do índice {0}",n[0,0]);
        Console.WriteLine("Valor do índice {0}",n[1,2]);





    }
}