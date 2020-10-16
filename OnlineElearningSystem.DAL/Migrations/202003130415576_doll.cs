namespace OnlineElearningSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseId = c.Int(nullable: false, identity: true),
                        courseName = c.Int(nullable: false),
                        categoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.courseId)
                .ForeignKey("dbo.Categories", t => t.categoryId, cascadeDelete: true)
                .Index(t => t.categoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "categoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "categoryId" });
            DropTable("dbo.Courses");
        }
    }
}
