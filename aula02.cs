
using System;

class aula1{

static void Main(){

 int n1;
 string nota;
 
inicio:
 Console.WriteLine("Digite a nota:");
 n1= int.Parse(Console.ReadLine());
    if (n1>=50){
            if (n1>80){
                if(n1>90){
                        if(n1==100){nota = "Aprovado magnifico";
                }else{nota = "Aprovado excelente";}
            }else{nota = "Aprovado ótimo";}
        }else{nota = "Aprovado";}
    }else{
        if (n1 > 40){nota = "recuperacao";
        }else {nota = "reprovado";}
    }  
Console.WriteLine("nota {0}",nota);
goto inicio;

}
}