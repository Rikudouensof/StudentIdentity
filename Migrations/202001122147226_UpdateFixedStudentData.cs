namespace StudentIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFixedStudentData : DbMigration
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
                "dbo.ModeOfStudies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Programmes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentModes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.FixedStudentDatas", "DepartmentId", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "StudentTypeId", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "ProgrammeId", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "StudentModeId", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "ModeOfStudyId", c => c.String());
            AlterColumn("dbo.FixedStudentDatas", "EntryYear", c => c.Int(nullable: false));
            CreateIndex("dbo.FixedStudentDatas", "Id");
            AddForeignKey("dbo.FixedStudentDatas", "Id", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FixedStudentDatas", "Id", "dbo.ModeOfStudies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FixedStudentDatas", "Id", "dbo.Programmes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FixedStudentDatas", "Id", "dbo.StudentModes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FixedStudentDatas", "Id", "dbo.StudentTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.FixedStudentDatas", "Department");
            DropColumn("dbo.FixedStudentDatas", "StudentType");
            DropColumn("dbo.FixedStudentDatas", "Programme");
            DropColumn("dbo.FixedStudentDatas", "StudentMode");
            DropColumn("dbo.FixedStudentDatas", "ModeOfStudy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FixedStudentDatas", "ModeOfStudy", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "StudentMode", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "Programme", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "StudentType", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "Department", c => c.String());
            DropForeignKey("dbo.FixedStudentDatas", "Id", "dbo.StudentTypes");
            DropForeignKey("dbo.FixedStudentDatas", "Id", "dbo.StudentModes");
            DropForeignKey("dbo.FixedStudentDatas", "Id", "dbo.Programmes");
            DropForeignKey("dbo.FixedStudentDatas", "Id", "dbo.ModeOfStudies");
            DropForeignKey("dbo.FixedStudentDatas", "Id", "dbo.Departments");
            DropIndex("dbo.FixedStudentDatas", new[] { "Id" });
            AlterColumn("dbo.FixedStudentDatas", "EntryYear", c => c.String());
            DropColumn("dbo.FixedStudentDatas", "ModeOfStudyId");
            DropColumn("dbo.FixedStudentDatas", "StudentModeId");
            DropColumn("dbo.FixedStudentDatas", "ProgrammeId");
            DropColumn("dbo.FixedStudentDatas", "StudentTypeId");
            DropColumn("dbo.FixedStudentDatas", "DepartmentId");
            DropTable("dbo.StudentTypes");
            DropTable("dbo.StudentModes");
            DropTable("dbo.Programmes");
            DropTable("dbo.ModeOfStudies");
            DropTable("dbo.Departments");
        }
    }
}
