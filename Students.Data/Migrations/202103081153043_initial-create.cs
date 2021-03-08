namespace Students.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentProfessors",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Professor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Professor_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Professors", t => t.Professor_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Professor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentProfessors", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.StudentProfessors", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentProfessors", new[] { "Professor_Id" });
            DropIndex("dbo.StudentProfessors", new[] { "Student_Id" });
            DropTable("dbo.StudentProfessors");
            DropTable("dbo.Students");
            DropTable("dbo.Professors");
        }
    }
}
