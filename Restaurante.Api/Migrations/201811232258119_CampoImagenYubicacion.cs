namespace Restaurante.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoImagenYubicacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Detalle", "Ubicacion", c => c.String(maxLength: 200));
            AddColumn("dbo.Detalle", "Latitud", c => c.Double(nullable: false));
            AddColumn("dbo.Detalle", "Longitud", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Detalle", "Longitud");
            DropColumn("dbo.Detalle", "Latitud");
            DropColumn("dbo.Detalle", "Ubicacion");
        }
    }
}
