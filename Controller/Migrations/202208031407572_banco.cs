namespace Controller.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.Long(nullable: false),
                        RG = c.Long(nullable: false),
                        Endereco = c.String(),
                        N_Endereco = c.Int(nullable: false),
                        Bairro = c.String(),
                        CEP = c.Long(nullable: false),
                        Cidade = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
