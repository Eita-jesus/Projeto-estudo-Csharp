using System; 

class Aula22{

static void Main(){

    int[] num=new int[3]{10,20,30};
    string[] nome = {"Matheus Jesus", "Andre", "Marcos", "Paulo", "joao"};


/*O FOREACH é usado quando sabemos a quantidade de elementos daquela variável e se queremos mostrar esses elementos
Imagine que queremos executar os números 10 20 e 30 presente em um array. Com isso, podemos usar o foreach, outro exemplo e mostrar os nomes


*/

    foreach (int n in num)
    { Console.WriteLine(n);
        
    }
foreach (string nm in nome)
Console.WriteLine("{0}",nm);
{
    
}


    }

}