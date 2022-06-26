using System;

class aula15estudo{

    static void Main (){

        char transporte;
        int tempo = 0; 

Console.WriteLine("Parabéns! Você recebeu um prémio de viagem");
Console.WriteLine("Viagem de Mg até Bh");
Console.WriteLine("Escolha umas das opções: [a]=Avião | [c]= Carro | [o]=Onibus");
transporte =char.Parse (Console.ReadLine());
switch(transporte){

case'a':
tempo = 50;
break;

case 'c': 
tempo = 100;
break;

case 'o':
tempo = 500;
break;

default: 
tempo = -1;
break;
}

if (tempo<0){Console.WriteLine("transporte indisponível");

}else{Console.WriteLine("O tempo do seu passeio é de {0}",tempo);}






        }

    }

