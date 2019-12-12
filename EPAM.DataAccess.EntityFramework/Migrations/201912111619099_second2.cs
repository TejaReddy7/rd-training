namespace EPAM.DataAccess.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second2 : DbMigration
    {
        public override void Up()
        {
           
            RenameTable(name: "dbo.Students", newName: "Employees");
        }
        
        public override void Down()
        {
            
            RenameTable(name: "dbo.Master_Gender", newName: "MasterGenders");
        }
    }
}
