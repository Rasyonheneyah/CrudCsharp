using Microsoft.EntityFrameworkCore;
using academico.Models;

namespace academico.Data
{
    public class AcademicoContext:DbContext 
    {
        public AcademicoContext(DbContextOptions<AcademicoContext> options) : base(options)
        {

        }

        public DbSet<Instituicao> Instituicoes { get; set; }

    }
}
