namespace StudentIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSexModelClass : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SexModelClasses (Name) VALUES('Male')");
            Sql("INSERT INTO SexModelClasses (Name) VALUES('Female')");
            Sql("INSERT INTO SexModelClasses (Name) VALUES('Unknown')");
        }
        
        public override void Down()
        {
        }
    }
}
