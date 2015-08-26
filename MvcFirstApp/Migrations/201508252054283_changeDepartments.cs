namespace MvcFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDepartments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "Name");
        }
    }
}
