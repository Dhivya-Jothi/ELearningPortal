
namespace OnlineElearningSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class psych : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserDetails", "userName", c => c.String(nullable: false));
            AlterColumn("dbo.UserDetails", "confirmPassword", c => c.String(nullable: false));
            AlterColumn("dbo.UserDetails", "gender", c => c.String(nullable: false));
            AlterColumn("dbo.UserDetails", "userRole", c => c.String(nullable: false));
            DropColumn("dbo.UserDetails", "password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDetails", "password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.UserDetails", "userRole", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDetails", "gender", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDetails", "confirmPassword", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.UserDetails", "userName", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
