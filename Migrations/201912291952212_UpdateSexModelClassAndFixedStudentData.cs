namespace StudentIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSexModelClassAndFixedStudentData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FixedStudentDatas", "SexModelClassId", c => c.Int(nullable: false));
            CreateIndex("dbo.FixedStudentDatas", "SexModelClassId");
            AddForeignKey("dbo.FixedStudentDatas", "SexModelClassId", "dbo.SexModelClasses", "Id", cascadeDelete: true);
            DropColumn("dbo.FixedStudentDatas", "Sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FixedStudentDatas", "Sex", c => c.String(nullable: false));
            DropForeignKey("dbo.FixedStudentDatas", "SexModelClassId", "dbo.SexModelClasses");
            DropIndex("dbo.FixedStudentDatas", new[] { "SexModelClassId" });
            DropColumn("dbo.FixedStudentDatas", "SexModelClassId");
        }
    }
}
