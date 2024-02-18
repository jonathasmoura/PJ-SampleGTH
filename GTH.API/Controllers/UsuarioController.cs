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
			var usuario = new Usuario();

			usuario.NOME = registroUsuarioDto.Nome;
			usuario.SOBRENOME = registroUsuarioDto.SobreNome;

			if (usuario is null) { return BadRequest(); }

			_context.Usuarios.Add(usuario);
			_context.SaveChanges();

			return Ok();
		}
	}
}
