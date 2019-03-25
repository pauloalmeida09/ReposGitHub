using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Exemplo.VO
{
    class ACESSO
    {	[Key]
		[Required]
        public int Id_Empresa { get; set; }
		[Required]
        public int Id_Pessoa { get; set; }
		[Required]
        public string Status_Acesso { get; set; }
    }
}
