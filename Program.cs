
using System; // Chamando bibliotecas 
using System.Threading; // Chamando bibliotecas 
using System.Collections.Generic; //Biblioteca de listas

namespace EncontroOnline2
{

class Program
{
    static void Main(string[] args)
    {
        
        // Listagem de remoção
        Console.Clear(); //Limpando o console
        Console.ForegroundColor = ConsoleColor.DarkBlue; //Cor da frente do console    
        Console.BackgroundColor = ConsoleColor.White; //Cor de fundo do console    
        Console.WriteLine(@$"
        ***************************************
        *  Bem vindo ao Sistema de Cadastro!  *
        *                                     *
        *************************************** 
        ");
        barraCarregamento("Iniciando");

        string opcao;

        List<PessoaFisica> listaPF = new List<PessoaFisica>(); // Criando uma lista para armazenar os cadastros realizados
         List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();
            do{ // Executa todo o programa uma primeira vez
        Console.WriteLine(@$"    
        *************************************** 
        *  Escolha uma das opções abaixo:     *
        *   1 - Pessoa Física                 *
            2 - Listar Pessoa Física          *
        *   3 - Remover Pessoa Física         *    
        ***************************************
        *   4 - Pessoa Jurídica               *
        *   5 - Listar Pessoa Jurídica        *
        *   6 - Remover Pessoa Jurídica       *
        ***************************************
        *   0 - Sair                          * 
        ***************************************                      
        "); // @ -> muda a aparência do texto
               

        opcao = Console.ReadLine(); // Lê a linha digitada
        switch (opcao) // Utilizando a estrutura de repetição switch
        {
            case "1":
             Endereco end = new Endereco(); //instaciando um objeto do tipo Endereço

            Console.WriteLine ("Digite o Logradouro:");
            end.logradouro = Console.ReadLine(); // Lê uma linha

            Console.WriteLine ("Digite o Número:");
            end.numero = int.Parse(Console.ReadLine());//converter string para int através do Parse

            Console.WriteLine ("Digite o Complemento:");
            end.complemento = Console.ReadLine();
            
            string respostaComercial; //declarando as variaveis
            bool validado = true;
            do{///Fazendo o laço para verificação, se a resposta for diferente das solicitadas retorna ao laço
                Console.WriteLine(" O Endereço é Comercial? S/N?"); 
                respostaComercial = Console.ReadLine().ToUpper();//Transforma minusculo em maiusculo

             if(respostaComercial == "S" || respostaComercial == "N"){
             validado = false;
             } 
            if(respostaComercial == "S"){//Verificando se o endereço é comercial ou não
                end.enderecoComercial = true;
            }else{
                end.enderecoComercial = false;
            }
        }while(validado);        
            
            PessoaFisica novapf = new PessoaFisica();

            novapf.endereco = end; //Chamando as informações do endereço através do end
            Console.WriteLine ("Digite o CPF:");
            novapf.cpf = Console.ReadLine();

            Console.WriteLine ("Digite o Nome:");
            novapf.nome = Console.ReadLine();

            Console.WriteLine ("Digite seu rendimento mensal:");
            novapf.rendimento = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a Data de Nascimento:");
            novapf.dataNascimento = DateTime.Parse(Console.ReadLine());//Convertendo date para string
            //new DateTime (1994, 10, 22); // Data de acordo com os EUA
            
          
            PessoaFisica pf = new PessoaFisica(); //Instanciando novamente PessoaFisica

            
            bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);
            Console.WriteLine(idadeValida);

            if (idadeValida == true ) {
            
            Console.WriteLine($"Cadastro Aprovado");
            listaPF.Add(novapf);//Adicionando os cadastros aprovados na lista
            Console.WriteLine(novapf.PagarImposto(novapf.rendimento));

            }else{

            Console.WriteLine($"Cadastro reprovado");
            
            }
            Thread.Sleep(3500);

            break;

            case "2": //Criando a lista 

                foreach (var pessoaFisica in listaPF)//For que não sabe a quantidade
                {
                   Console.WriteLine($"Nome: {pessoaFisica.nome} - CPF: {pessoaFisica.cpf} - Data de Nascimento: {pessoaFisica.dataNascimento}"); 
                }
               
            break;

            case "3": //Realizar uma busca através de algum dado para remoção

            Console.WriteLine("Digite o CPF da pessoa a ser removida:");
            string cpf = Console.ReadLine();
            //1º - Localizar o objeto com o CPF
            PessoaFisica pessoaRetornada = listaPF.Find(PessoaFisica => PessoaFisica.cpf == cpf);//Procura dentro cada objeto da lista, cada item da lista

            if(pessoaRetornada != null){//verificando o retorno do CPF buscado
                listaPF.Remove(pessoaRetornada);
                Console.WriteLine("Pessoa Removida com Sucesso");
            }else{
                Console.WriteLine("CPF não encontrado");
            }
            break;

            case "4":

            Endereco end2 = new Endereco(); //instaciando um objeto do tipo Endereço

            Console.WriteLine ("Digite o Logradouro:");
            end2.logradouro = Console.ReadLine(); // Lê uma linha

            Console.WriteLine ("Digite o Número:");
            end2.numero = int.Parse(Console.ReadLine());//converter string para int através do Parse

            Console.WriteLine ("Digite o Complemento:");
            end2.complemento = Console.ReadLine();
            
            string respostaComercialPj; //declarando as variaveis
            bool validadoPj = true;
            do{///Fazendo o laço para verificação, se a resposta for diferente das solicitadas retorna ao laço
                Console.WriteLine(" O Endereço é Comercial? S/N?"); 
                respostaComercialPj = Console.ReadLine().ToUpper();//Transforma minusculo em maiusculo

             if(respostaComercialPj == "S" || respostaComercialPj == "N"){
             validadoPj = false;
             } 
            if(respostaComercialPj == "S"){//Verificando se o endereço é comercial ou não
                end2.enderecoComercial = true;
            }else{
                end2.enderecoComercial = false;
            }
        }while(validadoPj);        
            
            PessoaJuridica pj = new PessoaJuridica();
            PessoaJuridica novapj = new PessoaJuridica();           

           
            novapj.endereco = end2; //Chamando as informações do endereço através do end
            Console.WriteLine ("Digite o CNPJ:");
            novapj.cnpj = Console.ReadLine();

            
            Console.WriteLine("Razão Social:");
            novapj.razaoSocial = Console.ReadLine();

            Console.WriteLine ("Digite o Nome:");
            novapj.nome = Console.ReadLine();
          
            pj.ValidarCNPJ(novapj.cnpj);
            {
            if (pj.ValidarCNPJ(novapj.cnpj)) {
            
            Console.WriteLine("CNPJ válido!");
            Console.WriteLine($"Cadastro Aprovado");
            listaPJ.Add(novapj);//Adicionando os cadastros aprovados na lista

            }else{

            Console.WriteLine("CNPJ inválido!");
            Console.WriteLine($"Cadastro reprovado");
            }
            
            }
            
            Thread.Sleep(3500);
            break;


            case "5": //Criando a lista de pessoa juridica

                foreach (var pessoaJuridica in listaPJ)//For que não sabe a quantidade
                {
                   Console.WriteLine($"Nome: {pessoaJuridica.nome} - CNPJ: {pessoaJuridica.cnpj} - Razão Social: {pessoaJuridica.razaoSocial}"); 
                }

            break;

            case "6": //Realizar uma busca através de algum dado para remoção

            Console.WriteLine("Digite o CNPJ da empresa a ser removida:");
            string cnpj = Console.ReadLine();
            //1º - Localizar o objeto com o CNPJ
            PessoaJuridica pjRetornada = listaPJ.Find(PessoaJuridica => PessoaJuridica.cnpj == cnpj);//Procura dentro cada objeto da lista, cada item da lista

            if(pjRetornada != null){//verificando o retorno do CPF buscado
                listaPJ.Remove(pjRetornada);
                Console.WriteLine("Empresa Removida com Sucesso");
            }else{
                Console.WriteLine("CNPJ não encontrado");
            }
            break;

            case "0":
             Console.WriteLine ($"Obrigado por utilizar nosso Sistema!");
             barraCarregamento("Finalizando");// Chamando o parametro
            break;

            default: //Nenhuma da opções
            Console.WriteLine ($"Opção inválida. Digite uma opção válida!");
            break;
        }
            } while (opcao != "0"); // Continua executando enquanto a condição for verdadeira; Enquanto a opção for diferente de 0
       
            

        static void barraCarregamento(string textoCarregamento){//Parametro do método
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.Write(textoCarregamento); // Chamando o parametro
            Thread.Sleep(500); //500 milisegundos)// Chamando uma biblioteca nova
        
             for (var cont = 0; cont < 10; cont ++){

            Console.Write("."); // Texto na mesma linha
            Thread.Sleep(500);

             } 
             Console.ResetColor();
        }


    }   

}
}
