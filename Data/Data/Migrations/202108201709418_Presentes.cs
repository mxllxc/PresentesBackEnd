namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Presentes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Presentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descrição = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Presentes");
        }
    }
}
