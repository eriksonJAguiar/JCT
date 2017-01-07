namespace CCT.Horarios.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        sigla = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Campus");
        }
    }
}
