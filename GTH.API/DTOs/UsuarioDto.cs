namespace GTH.API.DTOs
{
	public class UsuarioDto
	{
		public int ID { get; set; }
		public string NOME { get; set; } = "";
		public string SOBRENOME { get; set; } = "";
		public string ENDERECO { get; set; } = "";
		public string CPFCNPJ { get; set; } = ""	;
		public string EMAIL { get; set; } = ""	;
		public string SENHA { get; set; } = "";
		public Boolean ADMINISTRADOR { get; set; }

	}
}
