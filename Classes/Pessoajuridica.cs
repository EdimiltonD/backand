using backand.Interfaces;

namespace backand.Classes
{
    public class Pessoajuridica : Pessoa, IPessoajuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}