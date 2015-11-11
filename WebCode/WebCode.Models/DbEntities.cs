using System.Data.Entity;

namespace WebCode.Models
{
    public class DbEntities : DbContext
    {
        public DbEntities() : base("name=DefaultConnection")
        {
            Database.SetInitializer<DbEntities>(null);
        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberLog> MemberLogs { get; set; }

        public virtual DbSet<Curriculum> Curriculums { get; set; }
    }
}
