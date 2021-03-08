namespace Students.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Entity_Department : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentDepartments",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Department_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Department_Id);
            
            AddColumn("dbo.Professors", "DepartmentId", c => c.Int());
            CreateIndex("dbo.Professors", "DepartmentId");
            AddForeignKey("dbo.Professors", "DepartmentId", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentDepartments", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.StudentDepartments", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Professors", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.StudentDepartments", new[] { "Department_Id" });
            DropIndex("dbo.StudentDepartments", new[] { "Student_Id" });
            DropIndex("dbo.Professors", new[] { "DepartmentId" });
            DropColumn("dbo.Professors", "DepartmentId");
            DropTable("dbo.StudentDepartments");
            DropTable("dbo.Departments");
        }
    }
}
