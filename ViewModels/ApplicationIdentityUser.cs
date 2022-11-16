using Microsoft.AspNetCore.Identity;

namespace LanchesMac.ViewModels
{
    public class ApplicationIdentityUser: IdentityUser
    {
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }

       
    }
}
