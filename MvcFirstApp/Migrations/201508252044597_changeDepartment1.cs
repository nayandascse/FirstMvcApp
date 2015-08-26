namespace MvcFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDepartment1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Departments", "Name");
        }
    }
}
