namespace OnlineElearningSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class g : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserDetails", name: "confirmPassword", newName: "Password");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.UserDetails", name: "Password", newName: "confirmPassword");
        }
    }
}
