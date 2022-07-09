namespace EncontroOnline2
{
    public class PessoaJuridica: Pessoa
    {
         
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }
        
        public bool ValidarCNPJ(string cnpj)
        {
             
        if (cnpj.Length >= 14 && cnpj.Substring(cnpj.Length -4) == "0001"){//verificando a quantidade caracteres do cnpj através do length e se os ultimos digitos são iguais a 0001. Substring retorna determinada posicao do string
                return true;
        }else{
                return false;
        }

        }
    }

}

          