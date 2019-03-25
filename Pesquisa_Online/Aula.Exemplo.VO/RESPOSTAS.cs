using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Exemplo.VO
{
    class RESPOSTAS
    {
		[Key]
		[Required]
        public int Id_Perguntas { get; set; }
		[Required]
        public int Id_Pessoa { get; set; }
		[Required]
        public int Id_Respostas { get; set; }
		[Required]
        public int Id_Camapanha { get; set; }
		[Required]
        public int Id_Empresa { get; set; }
		[Required]
        public string Resposta_1 { get; set; }
        public string Resposta_2 { get; set; }
        public string Resposta_3 { get; set; }
        public string Resposta_4 { get; set; }
        public string Resposta_5 { get; set; }
        public string Resposta_6 { get; set; }
        public string Resposta_7 { get; set; }
        public char Resultado { get; set; }
    }
}
