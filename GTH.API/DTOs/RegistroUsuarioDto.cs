using System.ComponentModel.DataAnnotations;

namespace GTH.API.DTOs
{
	public class RegistroUsuarioDto
	{
		
		public int Id { get; set; }
		public string Nome { get; set; } = null!;
		public string SobreNome { get; set; } = null!;
		public string Endereco { get; set; } = null!;
		public string CPFCNPJ { get; set; } = null!;

		[Required, DataType(DataType.EmailAddress)]
		public string Email { get; set; } =  null!;

		[Required, DataType(DataType.Password, ErrorMessage = "Senha é obrigatório")]
		public string Senha { get; set; } = null!;

		[DataType(DataType.Password), Compare(nameof(Senha), ErrorMessage = "As senhas não estão iguais!")]
		public string ConfirmaSenha { get; set; } = null!;
		public bool Admin { get; set; }
	}
}
