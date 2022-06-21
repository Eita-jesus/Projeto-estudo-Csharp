using System; 

class aula11{

static void Main(){

//ELSE significa CASO CONTRÁRIO
string resultado; 
int n1,n2,n3,n4,med;

Console.WriteLine("digite a sua nota:");
n1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("digite a sua nota:");
n2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("digite a sua nota:");
n3 = Int32.Parse(Console.ReadLine());
Console.WriteLine("digite a sua nota:");
n4 = Int32.Parse(Console.ReadLine());

med = (n1+n2+n3+n4)/4;


    //if (med < 70){resultado=" Aprovado com sucesso";}
       
           // if (med == 100){resultado = " Você é um mito";}

if (med >= 50){
    if(med>=90){
        if(med >90){resultado= "Aprovado com super louvor";
        }else{
        resultado="Aprovado com louvor";}
    }else{resultado="Aprovado";
        
        }
    
    }else{
       if (med>40){resultado= "Em recuperacao";
    }else{resultado="reprovado";
    }
 }

Console.WriteLine("Seu resuldado foi: {0} você foi {1}",med, resultado);

    }
}





