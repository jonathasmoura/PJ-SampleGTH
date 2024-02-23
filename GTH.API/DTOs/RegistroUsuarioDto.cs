using System.ComponentModel.DataAnnotations;

namespace GTH.API.DTOs
{
	public class RegistroUsuarioDto
	{
		public string Nome { get; set; } = "";
		public string SobreNome { get; set; } = "";
		public string Endereco { get; set; } = "";
		public string CPFCNPJ { get; set; } = "";

		[Required, DataType(DataType.EmailAddress)]
		public string Email { get; set; } = "";

		[Required, DataType(DataType.Password, ErrorMessage = "Senha é obrigatório")]
		public string Senha { get; set; } = "";

		[DataType(DataType.Password), Compare(nameof(Senha), ErrorMessage = "As senhas não estão iguais!")]
		public string ConfirmaSenha { get; set; } = "";
		public bool Admin { get; set; }
	}
}
