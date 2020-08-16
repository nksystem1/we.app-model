using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace we.app_model.Data
{
    [Serializable]
    public class UnidadMedida
    {

		[Required]
		[MaxLength(3)]
		public string abrevunidadmedida { get; set; }
		[Required]
		[MaxLength(120)]
		public string nomunidadmedida { get; set; }
		
		public string codnegocio { get; set; }
		
	}
}
