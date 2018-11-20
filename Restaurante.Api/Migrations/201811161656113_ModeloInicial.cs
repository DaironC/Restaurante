namespace Restaurante.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Detalle",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Informacion_Id = c.Int(nullable: false),
                        Domicilios = c.String(maxLength: 50),
                        Reservas = c.String(maxLength: 50),
                        Descuentos = c.String(maxLength: 50),
                        Informacion_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Informacion", t => t.Informacion_Id1)
                .Index(t => t.Informacion_Id1);
            
            CreateTable(
                "dbo.Informacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        Especilidad = c.String(nullable: false, maxLength: 30),
                        Horario = c.String(nullable: false, maxLength: 30),
                        Direccion = c.String(nullable: false, maxLength: 30),
                        Imagen = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Validar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Espermitido = c.Boolean(nullable: false),
                        Mensaje = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detalle", "Informacion_Id1", "dbo.Informacion");
            DropIndex("dbo.Detalle", new[] { "Informacion_Id1" });
            DropTable("dbo.Validar");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Informacion");
            DropTable("dbo.Detalle");
        }
    }
}
