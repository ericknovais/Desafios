namespace Desafio2.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteNometabela : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Usuaios", newName: "Usuarios");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Usuarios", newName: "Usuaios");
        }
    }
}
