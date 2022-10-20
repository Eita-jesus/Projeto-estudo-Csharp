using System;
class Veiculo{

    public int rodas;

    public int VelMax;

    private bool ligado;

//Abaixo o construtor//
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }

public string getligado(){
    if (ligado){
    return "sim";
}else {
    return "não";
    }
}
}


class Carro:Veiculo{
   public string nome; 
    public string cor; 
    public Carro (string nome, string cor){
        desligar();
        rodas = 4;
        VelMax = 320;

        this.nome=nome;
        this.cor=cor;
    }

}


class Aula34{
    static void Main (){

        Carro c1=new Carro("Rapidão", "Vermelho");

        Console.WriteLine ("Cor........: {0}",c1.cor);
        Console.WriteLine ("Nome.......: {0}",c1.nome);
        Console.WriteLine ("Rodas......: {0}",c1.rodas);
        Console.WriteLine ("Vel.Maxima.: {0}",c1.VelMax);
        Console.WriteLine ("Ligado.....: {0}",c1.getligado());
        

    }

}