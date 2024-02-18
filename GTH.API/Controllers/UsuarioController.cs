using GTH.API.DataContexts;
using GTH.API.DTOs;
using GTH.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GTH.API.Controllers
{
	public class UsuarioController : Controller
	{
		private readonly PJGTHContext _context;
		public UsuarioController(PJGTHContext context)
		{
			_context = context;
		}
		[HttpPost]
		[Route("RegistrarUsuario")]
		public ActionResult RegistrarUsuario(RegistroUsuarioDto registroUsuarioDto)
		{
			try
			{
				var usuario = new Usuario();

				usuario.NOME = string.IsNullOrEmpty(registroUsuarioDto.Nome) ? string.Empty : registroUsuarioDto.Nome;
				usuario.SOBRENOME = string.IsNullOrEmpty(registroUsuarioDto.SobreNome) ? string.Empty : registroUsuarioDto.SobreNome;
				usuario.ENDERECO = string.IsNullOrEmpty(registroUsuarioDto.Endereco) ? string.Empty : registroUsuarioDto.Endereco;
				usuario.CPFCNPJ = string.IsNullOrEmpty(registroUsuarioDto.CPFCNPJ) ? string.Empty : registroUsuarioDto.CPFCNPJ;
				usuario.EMAIL = string.IsNullOrEmpty(registroUsuarioDto.Email)? string.Empty : registroUsuarioDto.Email;
				usuario.SENHA = string.IsNullOrEmpty(registroUsuarioDto.Senha)? string.Empty : registroUsuarioDto.Senha;
				usuario.ADMINISTRADOR = registroUsuarioDto.Admin ? true : false;

				if (usuario is null) { return BadRequest(); }

				_context.Usuarios.Add(usuario);
				_context.SaveChanges();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Não foi possível cadastrar na base, verificar se os dados foram preenchidos corretamente!", ex.Message);
				return BadRequest();
			}

			return Ok();
		}
	}
}
