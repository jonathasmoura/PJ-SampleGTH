namespace GTH.API.DTOs
{
	public class RegistroUsuarioDto
	{
		public string? Nome { get; set; }
		public string? SobreNome { get; set; }
		public string? Endereco { get; set; }
		public string? CPFCNPJ { get; set; }
		public string? Email { get; set; }
		public string? Senha { get; set; }
		public bool Admin { get; set; }
	}
}
