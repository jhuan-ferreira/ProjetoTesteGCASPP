namespace ProjetoTesteGCASPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        IdFuncionario = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Salario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdFuncionario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funcionarios");
        }
    }
}
