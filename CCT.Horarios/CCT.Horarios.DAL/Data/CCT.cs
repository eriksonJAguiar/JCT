namespace CCT.Horarios.DAL.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CCT : DbContext
    {
        public CCT()
            : base("name=CCT.Horarios")
        {
        }

        public virtual DbSet<Campus> Campus { get; set; }
    }

}