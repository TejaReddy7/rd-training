namespace EPAM.DataAccess.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.MasterGenders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterQuarters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterStreams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.EmployeesParameters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeesParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Dob = c.DateTime(nullable: false),
                        GenderId = c.Int(nullable: false),
                        Batch = c.String(),
                        Stream = c.String(),
                        QuarterId = c.Int(nullable: false),
                        Gender = c.String(),
                        Quarter = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.MasterStreams");
            DropTable("dbo.MasterQuarters");
            DropTable("dbo.MasterGenders");
            RenameTable(name: "dbo.EmployeesTable", newName: "EmployeesTable");
        }
    }
}
