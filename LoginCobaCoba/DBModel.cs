namespace LoginCobaCoba
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Akun> Akun { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Loker> Loker { get; set; }
        public virtual DbSet<Lomba> Lomba { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
