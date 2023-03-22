namespace Desafio2.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColunaAtivo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuaios", "Ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuaios", "Ativo");
        }
    }
}
