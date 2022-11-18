using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    {
       
       
        private string _name;
        [Required(ErrorMessage = "Informe o Nome")]
        [Display(Name = "Usuário")]
     
        public string UserName
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != null && _name.Equals(value))
                {
                    return;
                }
                _name ??= Regex.Replace(value, @"\s+", " ");
                

            }
        }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    
        public string ReturnUrl { get; set; }
    }
}
