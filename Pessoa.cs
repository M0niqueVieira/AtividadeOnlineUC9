//Atividade feita baseada no diagrama 10/02/22
namespace EncontroOnline2
{
    public abstract class Pessoa // Classe mãe
    {
        public string? nome {get; set;}
        public Endereco? endereco { get; set; }//Chamando a classe Endereco e o valor da varivável endereco
        
        
       // public abstract void PagarImposto();//Classe abstrata não pode ser instancidada

      
    }
}