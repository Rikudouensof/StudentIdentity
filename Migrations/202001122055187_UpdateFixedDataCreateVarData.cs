namespace StudentIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFixedDataCreateVarData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VarStudentDatas",
                c => new
                    {
                        RegNumber = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        DateofBirth = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        StateofOrigin = c.String(),
                        LGAofOrigin = c.String(),
                        HomeTown = c.String(),
                        ParmanentAddress = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        ContactAddress = c.String(),
                        Bloodgroup = c.String(),
                        Genotype = c.String(),
                        Religion = c.String(),
                        Email = c.String(),
                        SponsorName = c.String(),
                        SponsorAddress = c.String(),
                        SponsorPhoneNumber = c.Int(nullable: false),
                        SponsorEmail = c.String(),
                        SponsorRelationship = c.String(),
                        NextOfKinName = c.String(),
                        NextOfKinAddress = c.String(),
                        NextOfKinPhoneNumber = c.Int(nullable: false),
                        NextOfKinEmail = c.String(),
                        NextOfKinRelationship = c.String(),
                        Diabeties = c.Boolean(nullable: false),
                        Hypertention = c.Boolean(nullable: false),
                        Disabilities = c.Boolean(nullable: false),
                        Blind = c.Boolean(nullable: false),
                        Epilepsy = c.Boolean(nullable: false),
                        Asthma = c.Boolean(nullable: false),
                        SpectacleUse = c.Boolean(nullable: false),
                        SickleCell = c.Boolean(nullable: false),
                        Allergies = c.Boolean(nullable: false),
                        PreviousSurgery = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RegNumber);
            
            AddColumn("dbo.FixedStudentDatas", "Department", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "StudentType", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "Programme", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "StudentMode", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "ModeOfStudy", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "EntryYear", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "YearOfGradution", c => c.String());
            AddColumn("dbo.FixedStudentDatas", "YearOfStudy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FixedStudentDatas", "YearOfStudy");
            DropColumn("dbo.FixedStudentDatas", "YearOfGradution");
            DropColumn("dbo.FixedStudentDatas", "EntryYear");
            DropColumn("dbo.FixedStudentDatas", "ModeOfStudy");
            DropColumn("dbo.FixedStudentDatas", "StudentMode");
            DropColumn("dbo.FixedStudentDatas", "Programme");
            DropColumn("dbo.FixedStudentDatas", "StudentType");
            DropColumn("dbo.FixedStudentDatas", "Department");
            DropTable("dbo.VarStudentDatas");
        }
    }
}
