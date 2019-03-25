using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Exemplo.VO
{
    class CAMPANHA
    {	[Key]
		[Required]
        public int Id_Campanha { get; set; }
		[Required]
        public int Id_Empresa { get; set; }
		[Required]
        public string Nome { get; set; }
		[Required]
		[Display(Name = "Data Inicio")]
		[DisplayFormat(DataFormatString = "mm/dd/yyyy")]
		public DateTime Dt_Inicio { get; set; }
		[Required]
		[Display(Name = "Data Fim")]
		[DisplayFormat(DataFormatString = "mm/dd/yyyy")]
		public DateTime Dt_Fim { get; set; }
    }
}
