using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Exemplo.VO
{
    class PERGUNTAS
    {	
		[Key]
		[Required]
        public int Id_Perguntas { get; set; }
		[Required]
        public int Id_Camapanha { get; set; }
		[Required]
        public int Id_Empresa { get; set; }
		[Required(ErrorMessage = "Campo Pergunta deve ser Obrigatório", AllowEmptyStrings = false)]
		[Display(Name = "PERGUNTA")]
		public string Pergunta_1 { get; set; }
        public string Pergunta_2 { get; set; }
        public string Pergunta_3 { get; set; }
        public string Pergunta_4 { get; set; }
        public string Pergunta_5 { get; set; }
        public string Pergunta_6 { get; set; }
        public string Pergunta_7 { get; set; }
    }
}
