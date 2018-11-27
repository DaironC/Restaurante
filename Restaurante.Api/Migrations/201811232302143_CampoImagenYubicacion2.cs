namespace Restaurante.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoImagenYubicacion2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Informacion", "Imagen", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Informacion", "Imagen", c => c.String(nullable: false));
        }
    }
}
