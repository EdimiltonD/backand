using System.Text.RegularExpressions;
using backand.Interfaces;

namespace backand.Classes
{
    public class Pessoajuridica : Pessoa, IPessoajuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
           if (rendimento < 3000)
            {
              return  rendimento * 0.03f;

            }
            
            else if (rendimento > 3000 && rendimento <= 6000)
            {
             
             return  rendimento * 0.05f;
            }
            
            else if (rendimento > 6000 && rendimento <= 10000)
            {
              
              return  rendimento * 0.07f;

            }
            else
            {
             
              return  rendimento * 0.09f;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
           bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");

           if (retornoCnpjValido)
{
        string SubstringCnpj = cnpj.Substring(8 , 4);
        
        if(SubstringCnpj =="0001");
        {
          return true;
        }

        }
        return false;
        }
    }
}
