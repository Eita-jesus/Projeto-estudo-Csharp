//SWITCH uso dele na programação

using System;

class Aula15{
    static void Main(){

        int tempo=0;
        char escolha;

        Console.WriteLine("Belo Horizonete/MG a Vitória/ES");
        Console.WriteLine("Escolha um transporte: [a}Avião | [c]Carro | [o]ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case'a':
            tempo = 50;
            break;
            case'c':
            tempo = 450;
            break;
            case'o':
            tempo=660;
            break;
            default:
            tempo=-1;
            break;

                if (tempo < 0)
                {
                    Console.WriteLine("Transporte indisponível");
                }
                else
                { Console.WriteLine("Para o transporte escolhido o tempo é: {0}minutos", tempo); }


        }


    }

}