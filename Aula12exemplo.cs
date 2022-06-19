using System; 

class aula11{

static void Main(){

//Se nota for maior ou igual a 10 mostre a mensagem aprovado

// Símbolos usandos para expressõs Maior ou menor >< , igual = 

int n1;
string resultado = "Reprovado";

Console.WriteLine("Digite a nota:");
n1 = Int32.Parse(Console.ReadLine());


if (n1 >= 60){resultado="APROVADO";
   }

   Console.WriteLine("Resultado: {0}",resultado);
}
}





