using backand.Interfaces;

namespace backand.Classes
{
    public class Pessoafisica : Pessoa , IPessoafisica 
    {
        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}