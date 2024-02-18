using System.ComponentModel.DataAnnotations;

namespace GTH.API.Models
{
	public class Usuario
	{
		[Key]
        public int ID { get; set; }
        public string NOME { get; set; } = null!;
		public string SOBRENOME { get; set; } = null!;
		public string ENDERECO { get; set; } = null!;
		public string CPFCNPJ { get; set; } = null!;
		public string EMAIL { get; set; } = null!;
		public string SENHA { get; set; } = null!;
		public Boolean ADMINISTRADOR { get; set; }
	}
}
