namespace EncontroOnline2
{
    public class PessoaFisica: Pessoa // Classe filha
    {   
       public string? cpf { get; set; }

       public float rendimento { get; set; }
       public DateTime dataNascimento { get; set; }
       
      // public override void PagarImposto(float salario) // Sobrescrita 
       
          public bool ValidarDataNascimento(DateTime dataNasc){//Método para validar a data de nascimento - Saber se a pessoa é maior de 18 anos
            DateTime dataAtual = DateTime.Today; // Pegando a data de hoje (today) pelo sistema

            double anos = (dataAtual - dataNasc) .TotalDays / 365; // Verificando a idade da pessoa

            if (anos >= 18){
                    return true;

            }else{
                    return false;

            }
        }
    }
}