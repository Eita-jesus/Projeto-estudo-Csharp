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

if (med >= 60){resultado= "Aprovado";}
else {resultado= "reprovado";}

Console.WriteLine("Seu resuldado foi: {0}você foi {1}",med, resultado);

    }
}





