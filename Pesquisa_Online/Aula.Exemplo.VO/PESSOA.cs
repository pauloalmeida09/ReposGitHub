using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Exemplo.VO
{
    class PESSOA
    {	[Key]
		[Required]
        public int Id_Pessoa { get; set; }
		[Display(Name = "CPF")]
		[Required(ErrorMessage = "O CPF é obrigatório", AllowEmptyStrings = false)]
		public string CPF { get; set; }
		[Required(ErrorMessage = "O Nome do usuário é obrigatório", AllowEmptyStrings = false)]
		[Display(Name = "Nome")]
        public string Nome { get; set; }
		[Required(ErrorMessage = "O campo Senha deve ser preenchido", AllowEmptyStrings = false)]
		[Display(Name = "Senha")]
		[DataType(DataType.Password)]
		[StringLength(10, MinimumLength = 4)]
		public string Senha { get; set; }
		[Required]
        public string Login { get; set; }

		[Required(ErrorMessage = "O campo Email deve ser preenchido", AllowEmptyStrings = false)]
		[RegularExpression("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$;", ErrorMessage = "Informe um email válido...")]
		[DataType(DataType.EmailAddress)]
		[Display(Name = "Email")]
		public string Email { get; set; }
    }
}
