using academico.Data;
using academico.Models

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace academico.Controllers
{
    public class InstituicaoController : Controller
    {

        private static IList<Instituicao> instituicoes = new List<Instituicao>()

        {   
            new Instituicao {
                    InstituicaoId = 1,
                    Nome = "UGB-VR",
                    Endereco = "Volta Redonda" 
            }, 
            new Instituicao {
                InstituicaoId = 2,
                    Nome = "UGB-BP",
                    Endereco = "Barra do Praí" 
            }, 
            new Instituicao {
                InstituicaoId = 3,
                    Nome = "UGB-RJ",
                    Endereco = "Rio de Janeiro" 
            }
        };

        public IActionResult Index()
        {
            return View(instituicoes);
        }

    }

} 
