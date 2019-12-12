namespace EPAM.DataAccess.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmployeesTable", newName: "EmployeesTable");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EmployeesTable", newName: "EmployeesTable");
        }
    }
}
