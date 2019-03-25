using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Exemplo.VO
{
    class EMPRESA
    {
		[Key]
		[Required(ErrorMessage = "Necessário Informar o ID da Empresa", AllowEmptyStrings = false)]
		[Display(Name = "ID_EMPRESA")]
		public int Id_Empresa { get; set; }
		[Required(ErrorMessage = "O Nome da Empresa é Obrigatório", AllowEmptyStrings = false)]
		[Display(Name = "Nome")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "CNPJ Obrigatório", AllowEmptyStrings = false)]
		[Display(Name = "CNPJ")]
		public string CNPJ { get; set; }
    }
}
