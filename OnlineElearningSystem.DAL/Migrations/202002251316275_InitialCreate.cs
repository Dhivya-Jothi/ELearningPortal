namespace OnlineElearningSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        userId = c.String(nullable: false, maxLength: 128),
                        userName = c.String(nullable: false, maxLength: 30),
                        password = c.String(nullable: false, maxLength: 20),
                        confirmPassword = c.String(nullable: false, maxLength: 20),
                        gender = c.Int(nullable: false),
                        mobileNumber = c.String(nullable: false),
                        mailId = c.String(nullable: false),
                        dateOfBirth = c.String(),
                        mediumOfStudy = c.String(nullable: false),
                        userRole = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDetails");
        }
    }
}
