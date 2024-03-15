using GTH.API.DataContexts;
using GTH.API.DTOs;
using GTH.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace GTH.API.Controllers
{
	[AllowAnonymous]
	[Route("api/usuarios")]
	public class UsuarioController : ControllerBase
	{
		private readonly PJGTHContext _context;
		public UsuarioController(PJGTHContext context)
		{
			_context = context;
		}

		[HttpGet]
		[Route("todosusuarios")]
		public ActionResult<IEnumerable<UsuarioDto>> BuscarTodosUsuarios()
		{
			try
			{
				var usuarios = _context.Usuarios.AsNoTracking().ToList();

				if (usuarios is null) { return NotFound("Não foi possível recuperar os dados dos USUÁRIOS em nossa base de dados!"); }
				var retornoUsuarios = new List<UsuarioDto>();

				foreach (var item in usuarios)
				{
					retornoUsuarios.Add(new UsuarioDto()
					{
						ID = item.ID,
						NOME = item.NOME,
						SOBRENOME = item.SOBRENOME,
						CPFCNPJ = item.CPFCNPJ,
						EMAIL = item.EMAIL,
						ADMINISTRADOR = item.ADMINISTRADOR
					});
				}

				return retornoUsuarios;

			}
			catch (Exception)
			{

				return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação.");
			}

		}

		[HttpGet("obterusuario/{id}", Name = "detalheusuario")]
		public ActionResult<UsuarioDto> BuscarUsuarioPorId(int id)
		{
			var usuario = _context.Usuarios.FirstOrDefault(x => x.ID == id);

			if (usuario == null)
			{
				return NotFound($"Não foi possível recuperar os dados da USUÁRIO = {id} em nossa base de dados!");
			}

			var usuarioRetorno = new UsuarioDto
			{
				ID = usuario.ID,
				NOME = usuario.NOME,
				SOBRENOME = usuario.SOBRENOME,
				EMAIL = usuario.EMAIL,
				ADMINISTRADOR = usuario.ADMINISTRADOR
			};

			return Ok(usuarioRetorno);
		}

		[HttpPost]
		[Route("registrarusuario")]
		public ActionResult RegistrarUsuario([FromBody]RegistroUsuarioDto registroUsuarioDto)
		{
			try
			{

				if (registroUsuarioDto.Senha != registroUsuarioDto.ConfirmaSenha)
					return BadRequest("As senhas informadas não estão iguais");


				var registroUsuario = new Usuario
				{
					NOME = registroUsuarioDto.Nome,
					SOBRENOME = registroUsuarioDto.SobreNome,
					ENDERECO = registroUsuarioDto.Endereco,
					CPFCNPJ = registroUsuarioDto.CPFCNPJ,
					EMAIL = registroUsuarioDto.Email,
					SENHA = registroUsuarioDto.Senha,
					ADMINISTRADOR = registroUsuarioDto.Admin
				};

				if (registroUsuario is null) { return BadRequest(); }

				_context.Usuarios.Add(registroUsuario);
				_context.SaveChanges();

				registroUsuarioDto.Senha = "";
				registroUsuarioDto.ConfirmaSenha = "";

				return new CreatedAtRouteResult("detalheusuario", new { ID = registroUsuario.ID }, registroUsuarioDto);

			}
			catch (Exception ex)
			{

				Console.WriteLine("Não foi possível cadastrar na base, verificar se os dados foram preenchidos corretamente!", ex.Message);
				return BadRequest();
			}

		}
	}
}
