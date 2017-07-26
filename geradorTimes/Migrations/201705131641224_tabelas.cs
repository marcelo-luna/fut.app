namespace geradorTimes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Posicao = c.Int(nullable: false),
                        Nivel = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Time_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.Time_Id)
                .Index(t => t.Time_Id);
            
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogadors", "Time_Id", "dbo.Times");
            DropIndex("dbo.Jogadors", new[] { "Time_Id" });
            DropTable("dbo.Times");
            DropTable("dbo.Jogadors");
        }
    }
}
