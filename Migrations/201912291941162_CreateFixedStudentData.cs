namespace StudentIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFixedStudentData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FixedStudentDatas",
                c => new
                    {
                        RegNumber = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        Surname = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        OtherName = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        JambRegNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RegNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FixedStudentDatas");
        }
    }
}
