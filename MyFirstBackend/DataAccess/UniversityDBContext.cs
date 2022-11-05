using Microsoft.EntityFrameworkCore;
using MyFirstBackend.Models.DataModels;

namespace MyFirstBackend.DataAccess
{
    public class UniversityDBContext : DbContext 
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {
        }

        //DBSETS -> Tablas de nuestra base de datos
        //cuando hagamos las migraciones van a usar estos sets para
        //va a crear tablas con todos los datos de el elemento (User) (la tabla se va a llamar Users)
        public DbSet<User>? Users { get; set; }
    }
}
