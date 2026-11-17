
using academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace academico.Controllers
{
    public class InstituicaoController : Controller
    {
        private static List<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao()
            {
                InstituicaoID = 1,
                Nome = "UGB-VR",
                Endereco = "Volta Redonda"
            },
            new Instituicao()
            {
                InstituicaoID = 2,
                Nome = "UGB-BP",
                Endereco = "Barra do Piraí"
            }
        };
        public IActionResult Index()
        {
            return View(instituicoes);
        }

        public ActionResult Create()
        {
            return View();
        }


    }
}
